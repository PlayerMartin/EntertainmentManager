using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EntertainmentManager
{
    public partial class SQLiteDataAccess
    {
        public const int CHARACTER_LIMIT = 200;
        private const string CONNECTION_STRING = "Data";
        private const string EDIT_ITEM = @"
                    UPDATE Library
                    SET
                        Title = @Title,
                        Type = @Type,
                        Released = @Released,
                        Runtime = @Runtime,
                        Genre = @Genre,
                        Tags = @Tags,
                        Rating = @Rating,
                        Progress = @Progress,
                        Status = @Status
                    WHERE ID = @ID";
        private const string DELETE_ITEM = @"DELETE FROM Library WHERE ID = @ID";
        private const string LOAD_ITEMS = @"SELECT * FROM Library WHERE Owner = @Username";
        private const string LOAD_ITEM = @"SELECT * FROM Library WHERE Title = @Title AND Owner = @Owner";
        private const string SAVE_ITEM = @"
                    INSERT INTO Library(Owner, Title, Released, Type, Runtime, Rating, Progress, Status, Poster, Genre, Tags)
                    VALUES (@Owner, @Title, @Released, @Type, @Runtime, @Rating, @Progress, @Status, @Poster, @Genre, @Tags)";
        private const string SAVE_USER = @"INSERT INTO Auth(Username, Password) values (@Username, @Password)";
        private const string LOAD_USER = @"SELECT Username FROM Auth WHERE Password = @Password AND Username = @Username";
        private const string DELETE_ITEMS = @"DELETE FROM Library WHERE Owner = @Owner";

        public static async Task<string?> LoadUser(User user)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    IEnumerable<string> res = await cnn.QueryAsync<string>(LOAD_USER, user);
                    return res.FirstOrDefault();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }

        public static Result SaveUser(User user)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    if (cnn.Execute(SAVE_USER, user) != 1)
                    {
                        return Result.FAILURE;
                    }
                }
            }
            catch (SQLiteException e)
            {
                if (e.Message.ToLower().Contains("unique"))
                {
                    return Result.NOT_UNIQUE;
                }
                return Result.FAILURE;
            }
            return Result.SUCCESS;
        }

        public static async Task<bool> SaveItem(Item item)
        {
            if (await LoadItem(item) != null)
            {
                return false;
            }
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync(SAVE_ITEM, item);
                }
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static async Task<bool> SaveItem(IEnumerable<Item> items, string username, bool overwrite)
        {
            if (overwrite)
            {
                if (!await DeleteItems(username))
                {
                    return false;
                }
            }

            try
            {
                foreach (Item item in items)
                {
                    if (!(await SaveItem(item)))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        private static async Task<Item?> LoadItem(Item item)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    return (await cnn.QueryAsync<Item>(LOAD_ITEM, item)).FirstOrDefault();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }

        public static async Task<bool> EditItem(Item item)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync(EDIT_ITEM, item);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static async Task<bool> DeleteItem(Item item)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync(DELETE_ITEM, item);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static async Task<bool> DeleteItems(string username)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync(DELETE_ITEMS, new { Owner = username });
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static async Task<IEnumerable<Item>?> LoadItems(string username)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    return (await cnn.QueryAsync<Item>(LOAD_ITEMS, new { Username = username })).ToList();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }

        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;
        }
    }
}
