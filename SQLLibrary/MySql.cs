using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLLibrary
{
    public class MySql
    {
        
        private static string connString = @"Data Source=.;Initial Catalog=WebshopDatabase;Integrated Security=True";

        public static int CreateContact(Customer customer)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddCustomer", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramFirstname = new SqlParameter("@Firstname", System.Data.SqlDbType.VarChar);
                paramFirstname.Size = 32;
                paramFirstname.Value = customer.Firstname;
                sqlCommand.Parameters.Add(paramFirstname);

                SqlParameter paramLastname = new SqlParameter("@Lastname", System.Data.SqlDbType.VarChar);
                paramLastname.Size = 32;
                paramLastname.Value = customer.Lastname;
                sqlCommand.Parameters.Add(paramLastname);

                SqlParameter paramSSN = new SqlParameter("@SSN", System.Data.SqlDbType.VarChar);
                paramSSN.Size = 13;
                paramSSN.Value = customer.SSN;
                sqlCommand.Parameters.Add(paramSSN);

                SqlParameter paramEmail = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                paramEmail.Size = 50;
                paramEmail.Value = customer.Email;
                sqlCommand.Parameters.Add(paramEmail);

                SqlParameter paramPassword = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                paramPassword.Size = 50;
                paramPassword.Value = customer.Password;
                sqlCommand.Parameters.Add(paramPassword);

           

                SqlParameter paramCID = new SqlParameter("@CID", System.Data.SqlDbType.Int);
                paramCID.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(paramCID);

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(paramCID.Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }



        //----------------------------------------------------------------


        public static int CreateAddress(Address address)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddAdress2", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramStreet = new SqlParameter("@Street", System.Data.SqlDbType.VarChar);
                paramStreet.Size = 50;
                paramStreet.Value = address.Street;
                sqlCommand.Parameters.Add(paramStreet);

                SqlParameter paramCity = new SqlParameter("@City", System.Data.SqlDbType.VarChar);
                paramCity.Size = 50;
                paramCity.Value = address.City;
                sqlCommand.Parameters.Add(paramCity);

                SqlParameter paramZIP = new SqlParameter("@ZIP", System.Data.SqlDbType.VarChar);
                paramZIP.Size = 7;
                paramZIP.Value = address.ZIP;
                sqlCommand.Parameters.Add(paramZIP);

                SqlParameter paramCountry = new SqlParameter("@Country", System.Data.SqlDbType.VarChar);
                paramCountry.Size = 32;
                paramCountry.Value = address.Country;
                sqlCommand.Parameters.Add(paramCountry);

                SqlParameter paramAID = new SqlParameter("@AID", System.Data.SqlDbType.Int);
                paramAID.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(paramAID);

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(paramAID.Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }

        public static int C2A(int cid, int aid)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddC2A", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramCID = new SqlParameter("@CID", System.Data.SqlDbType.Int);
                paramCID.Size = 50;
                paramCID.Value = cid;
                sqlCommand.Parameters.Add(paramCID);

                SqlParameter paramAID = new SqlParameter("@AID", System.Data.SqlDbType.Int);
                paramAID.Size = 50;
                paramAID.Value = aid;
                sqlCommand.Parameters.Add(paramAID);


                SqlParameter paramC2A = new SqlParameter("@C2A", System.Data.SqlDbType.Int);
                paramC2A.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(paramC2A);

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(paramC2A.Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }

        //----------------------------------------------------------------


        public static Customer ValidateLogin(string username, string password)
        {
            Customer customer = null;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                string sqlQuery = "select * from [Customer] where Email=@Email and Password=@Password";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                SqlParameter paramUsername = new SqlParameter("@Email", SqlDbType.VarChar);
                paramUsername.Value = username;
                sqlCommand.Parameters.Add(paramUsername);

                SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar);
                paramPassword.Value = password;
                sqlCommand.Parameters.Add(paramPassword);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();

                    int id = int.Parse(sqlDataReader["ID"].ToString());
                    string firstname = sqlDataReader["Username"].ToString();
                    string lastname = sqlDataReader["Password"].ToString();
                    string email = sqlDataReader["Email"].ToString();
                    

                    customer = new Customer(id, firstname, lastname, email);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return customer;
        }

        public static Product CreateProduct(int price, string pictureUrl, int stocknr, int soldnr, string productDescription)
        {

            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Int);
                priceParam.Value = price;
                command.Parameters.Add(priceParam);

                SqlParameter pictureUrlParam = new SqlParameter("@pictureurl", SqlDbType.VarChar);
                pictureUrlParam.Value = pictureUrl;
                command.Parameters.Add(pictureUrlParam);

                SqlParameter stocknrParam = new SqlParameter("@stocknr", SqlDbType.Int);
                stocknrParam.Value = stocknr;
                command.Parameters.Add(stocknrParam);

                SqlParameter soldnrParam = new SqlParameter("@soldnr", SqlDbType.Int);
                soldnrParam.Value = soldnr;
                command.Parameters.Add(soldnrParam);

                SqlParameter productDescriptionParam = new SqlParameter("@productdescription", SqlDbType.VarChar);
                productDescriptionParam.Value = productDescription;
                command.Parameters.Add(productDescriptionParam);

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                idParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParam);

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddProduct";
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return new Product(int.Parse(idParam.Value.ToString()), price, pictureUrl, stocknr, soldnr, productDescription);
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                connection.Close();
            }

            return null;
        }


















































        public static Product UpdateProduct(int idToUpdate, int price, string pictureUrl, int stocknr, int soldnr, string productDescription)
        {

            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                idParam.Value = idToUpdate;
                command.Parameters.Add(idParam);

                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Int);
                priceParam.Value = price;
                command.Parameters.Add(priceParam);

                SqlParameter pictureUrlParam = new SqlParameter("@pictureurl", SqlDbType.VarChar);
                pictureUrlParam.Value = pictureUrl;
                command.Parameters.Add(pictureUrlParam);

                SqlParameter stocknrParam = new SqlParameter("@stocknr", SqlDbType.Int);
                stocknrParam.Value = stocknr;
                command.Parameters.Add(stocknrParam);

                SqlParameter soldnrParam = new SqlParameter("@soldnr", SqlDbType.Int);
                soldnrParam.Value = soldnr;
                command.Parameters.Add(soldnrParam);

                SqlParameter productDescriptionParam = new SqlParameter("@productdescription", SqlDbType.VarChar);
                productDescriptionParam.Value = productDescription;
                command.Parameters.Add(productDescriptionParam);

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateProduct";
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return new Product(int.Parse(idParam.Value.ToString()), price, pictureUrl, stocknr, soldnr, productDescription);
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                connection.Close();
            }

            return null;
        }
    }
}
