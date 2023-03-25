
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Newtonsoft.Json;

using NatureEco.date;
using System.Diagnostics;
using Firebase.Database.Query;

namespace NatureEco
{
    class UserReposity
    {


        public static FirebaseClient firebase = new FirebaseClient("https://natureeco-7c21b-default-rtdb.firebaseio.com/");

        public static async Task<List<userModel>> GetAllUsers()
        {
            try
            {
                var userlist = (await firebase.Child("User").OnceAsync<userModel>()).Select(item =>

                    new userModel
                    {
                        Username = item.Object.Username,
                        Email = item.Object.Email,
                        Date  = item.Object.Date,
                        Password = item.Object.Password,
                        ProfilePic = item.Object.ProfilePic


                    }).ToList();

                return userlist;

            }

            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }

        }
        public static async Task<userModel> GetUser(string email)
        {
            try

            { 

                var allUsers = await GetAllUsers();
                await firebase
                  .Child("Users")
                    .OnceAsync<userModel>();
                return allUsers.Where(a => a.Email == email).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

      

        //query 
        public static async Task<bool>AddUser(string email, string password,string username,DateTime date)
            {
                try
                {
                await firebase
                  .Child("User")
                     .PostAsync(new userModel() { Email = email, Password = password, Username = username, Date = date });
                    return true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error:{e}");
                    return false;
                }
            }

        //update dos daodos

            public static async Task<bool> UpdateUser(string email, string password, string username, DateTime date)
            {
                try
                {
                var toUpdateUser = (await firebase
                  .Child("Users")
                   .OnceAsync<userModel>()).Where(a => a.Object.Email == email).FirstOrDefault();
                    await firebase
                      .Child("Users")
                        .Child(toUpdateUser.Key)
                          .PutAsync(new userModel() { Email = email, Password = password });
                    return true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error:{e}");
                    return false;
                }
            }
            public static async Task<bool> DeleteUser(string email)
            {
                try
                {
                    var toDeleteUser = (await firebase
                         .Child("Users")
                               .OnceAsync<userModel>()).Where(a => a.Object.Email == email).FirstOrDefault();

                    await firebase.Child("Users").Child(toDeleteUser.Key).DeleteAsync();
                    return true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error:{e}");
                    return false;
                }
            }


        }
        

        

    }

