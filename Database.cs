using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OnlyIphone
{
    class Database
    {
        //--------------- CRUD OUTCOME ---------------------------------
        public static int addOutcome(Outcome outcome)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO outcome (date,value,description,username)" +
                                     "VALUES(@outcome.date,@outcome.value,@outcome.description,@outcome.username)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@outcome.date", outcome.date);
                cmd.Parameters.AddWithValue("@outcome.value", outcome.value);
                cmd.Parameters.AddWithValue("@outcome.description", outcome.description);
                cmd.Parameters.AddWithValue("@outcome.username", outcome.username);
                retorno = cmd.ExecuteNonQuery();
                retorno = (int)cmd.LastInsertedId;
                con.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return retorno;
            }
        }
        //--------------- CRUD DETAIL-------------------------------------
        public static int addDetail(Detail detail)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO detail (quantity, total_price, sale, product)" +
                                     "VALUES(@detail.quantity,@detail.total_price,@detail.sale,@detail.product)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@detail.quantity", detail.quantity);
                cmd.Parameters.AddWithValue("@detail.total_price", detail.total_price);
                cmd.Parameters.AddWithValue("@detail.sale", detail.sale);
                cmd.Parameters.AddWithValue("@detail.product", detail.product);
                retorno = cmd.ExecuteNonQuery();
                retorno = (int)cmd.LastInsertedId;
                con.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return retorno;
            }
        }

        public static List<Detail> getDetails(int id)
        {
            List<Detail> detail = new List<Detail>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT quantity,total_price, product FROM detail WHERE sale={0}", id), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Detail details = new Detail();
                details.quantity = _reader.GetInt32(0);
                details.total_price = _reader.GetInt32(1);
                details.product = _reader.GetString(2);

                detail.Add(details);
            }
            return detail;
        }
        //-------------- CRUD SALE --------------------------------------
        public static int addSale(Sales sale)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO sale (date,total_account,payment_method, cashbox_date, client, username)" +
                                     "VALUES(@sale.date,@sale.total_account,@sale.payment_method,@sale.cashbox_date,@sale.client,@sale.username)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@sale.date", sale.date);
                cmd.Parameters.AddWithValue("@sale.total_account", sale.total_account);
                cmd.Parameters.AddWithValue("@sale.payment_method", sale.payment_method);
                cmd.Parameters.AddWithValue("@sale.cashbox_date", sale.cashbox_date);
                cmd.Parameters.AddWithValue("@sale.client", sale.client);
                cmd.Parameters.AddWithValue("@sale.username", sale.username);
                retorno = cmd.ExecuteNonQuery();
                retorno = (int)cmd.LastInsertedId;

                if (con.State == System.Data.ConnectionState.Open) con.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return retorno;
            }
        }
        public static List<Sales_Display> listSales(DateTime date)
        {
            List<Sales_Display> list = new List<Sales_Display>();
            int payment_method;
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, date, total_account, payment_method, client, username FROM sale WHERE cashbox_date='{0}'", date.ToString("s").Substring(0, 10)), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Sales_Display sale = new Sales_Display();
                sale.id = _reader.GetInt32(0);
                sale.date = _reader.GetDateTime(1);
                sale.total_account = _reader.GetInt32(2);
                payment_method = _reader.GetInt32(3);
                sale.payment_method = getPayment_Method(payment_method);
                sale.client = _reader.GetString(4);
                sale.username = _reader.GetString(5);
                list.Add(sale);

            }
            return list;
        }
        public static int deleteSale(int id)
        {
            int retorno = 0;
            try
            {
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE from sale WHERE id='{0}'", id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception k)
            {
                MessageBox.Show("No se pudo eliminar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }

        public static int getTotalSales(DateTime date)
        {
            MySqlConnection conexion = Connection.getConnection();
            string Query = "SELECT COUNT(*) AS Count FROM sale WHERE cashbox_date=?date";

            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            int value = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return value;
        }
        //-------------- CRUD DETAIL WORK ORDER --------------------------
        public static int addDetailWorkOrder(Detail_Work_Order detail)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO detail_work_order (quantity, total_price, work_order, product)" +
                                     "VALUES(@detail.quantity,@detail.total_price,@detail.work_order,@detail.product)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@detail.quantity", detail.quantity);
                cmd.Parameters.AddWithValue("@detail.total_price", detail.total_price);
                cmd.Parameters.AddWithValue("@detail.work_order", detail.work_order);
                cmd.Parameters.AddWithValue("@detail.product", detail.product);
                retorno = cmd.ExecuteNonQuery();
                retorno = (int)cmd.LastInsertedId;
                con.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return retorno;
            }
        }
        public static List<Detail_Work_Order> getDetailsWorkOrders(int id)
        {
            List<Detail_Work_Order> detail = new List<Detail_Work_Order>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT quantity,total_price, product FROM detail_work_order WHERE work_order={0}", id), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Detail_Work_Order details = new Detail_Work_Order();
                details.quantity = _reader.GetInt32(0);
                details.total_price = _reader.GetInt32(1);
                details.product = _reader.GetString(2);
                detail.Add(details);
            }
            return detail;
        }
        //-------------- CRUD WORK ORDER ---------------------------------
        public static int addWorkOrder(Work_Order work_order)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO work_order (date,total_account,payment_method, description, cashbox_date,username, client)" +
                                     "VALUES(@work_order.date,@work_order.total_account,@work_order.payment_method,@work_order.description,@work_order.cashbox_date,@work_order.username,@work_order.client)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@work_order.date", work_order.date);
                cmd.Parameters.AddWithValue("@work_order.total_account", work_order.total_account);
                cmd.Parameters.AddWithValue("@work_order.payment_method", work_order.payment_method);
                cmd.Parameters.AddWithValue("@work_order.description", work_order.description);
                cmd.Parameters.AddWithValue("@work_order.cashbox_date", work_order.cashbox_date);
                cmd.Parameters.AddWithValue("@work_order.username", work_order.username);
                cmd.Parameters.AddWithValue("@work_order.client", work_order.client);
                retorno = cmd.ExecuteNonQuery();
                retorno = (int)cmd.LastInsertedId;

                if (con.State == System.Data.ConnectionState.Open) con.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return retorno;
            }
        }
        public static List<Work_Order_Display> listWorkOrders(DateTime date)
        {
            List<Work_Order_Display> list = new List<Work_Order_Display>();
            int payment_method;
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, date, total_account, payment_method, description, client, username FROM work_order WHERE cashbox_date='{0}'", date.ToString("s").Substring(0, 10)), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Work_Order_Display work_order = new Work_Order_Display();
                work_order.Id = _reader.GetInt32(0);
                work_order.date = _reader.GetDateTime(1);
                work_order.total_account = _reader.GetInt32(2);
                payment_method = _reader.GetInt32(3);
                work_order.payment_method = getPayment_Method(payment_method);
                work_order.description = _reader.GetString(4);
                work_order.client = _reader.GetString(5);
                work_order.username = _reader.GetString(6);
                
                

                list.Add(work_order);
            }
            return list;

        }

        public static int deleteWorkOrder(int id)
        {
            int retorno = 0;
            try
            {
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE from work_order WHERE id='{0}'", id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception k)
            {
                MessageBox.Show("No se pudo eliminar la order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }

        public static int getTotalWorkOrder(DateTime date)
        {
            MySqlConnection conexion = Connection.getConnection();
            string Query = "SELECT COUNT(*) FROM work_order WHERE cashbox_date=?date";

            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            int value = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return value;
        }

        //-------------- CRUD CASHBOX ------------------------------------
        public static int addCashBox(Cashboxs cashbox)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO cashbox (date, income, outcome)" +
                                     "VALUES(@cashbox.date,@cashbox.income,@cashbox.outcome)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@cashbox.date", cashbox.date);
                cmd.Parameters.AddWithValue("@cashbox.income", cashbox.income);
                cmd.Parameters.AddWithValue("@cashbox.outcome", cashbox.outcome);
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ya se inició una caja hoy !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static int updateCashBox(Cashboxs cashbox,string type)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando;
                MySqlConnection conexion = Connection.getConnection();
                if (type == "income")
                {
                    comando = new MySqlCommand(string.Format("UPDATE cashbox SET income=income+{0} WHERE date='{1}'",cashbox.income, cashbox.date.ToString("s").Substring(0,10)), conexion);
                }
                else
                {
                    comando = new MySqlCommand(string.Format("UPDATE cashbox SET outcome=outcome+{0} WHERE date='{1}'", cashbox.outcome, cashbox.date.ToString("s").Substring(0, 10)), conexion);
                }
                
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Por favor, iniciar caja antes de realizar venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }

        public static int updateCashBox1(Cashboxs cashbox, string type)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando;
                MySqlConnection conexion = Connection.getConnection();
                if (type == "income")
                {
                    comando = new MySqlCommand(string.Format("UPDATE cashbox SET income=income-{0} WHERE date='{1}'", cashbox.income, cashbox.date.ToString("s").Substring(0, 10)), conexion);
                }
                else
                {
                    comando = new MySqlCommand(string.Format("UPDATE cashbox SET outcome=outcome-{0} WHERE date='{1}'", cashbox.outcome, cashbox.date), conexion);
                }

                retorno = comando.ExecuteNonQuery();
                Console.WriteLine(comando.LastInsertedId);
                conexion.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Por favor, iniciar caja antes de realizar venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }

        public static Cashboxs findCashBox(DateTime date)
        {
            Cashboxs cashbox = new Cashboxs();
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT date, income, outcome FROM cashbox where date='{0}'", date.ToString("s").Substring(0, 10)), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                
                cashbox.date = _reader.GetDateTime(0);
                cashbox.income = _reader.GetInt32(1);
                cashbox.outcome = _reader.GetInt32(2);
            }
            conexion.Close();
            return cashbox;
        }
        //-------------- CRUD CLIENT -------------------------------------
        public static int addClient(Clients client)
        {
            int retorno = 0;
            try
            {
                string QueryInsert = "INSERT INTO client (rut, names, last_names, email, phone, address)" +
                                     "VALUES(@client.Rut,@client.Name,@client.Last_name,@client.Email,@client.Phone,@client.Address)";
                MySqlConnection con = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = QueryInsert;
                cmd.Parameters.AddWithValue("@client.Rut", client.Rut);
                cmd.Parameters.AddWithValue("@client.Name", client.Name);
                cmd.Parameters.AddWithValue("@client.Last_name", client.Last_name);
                cmd.Parameters.AddWithValue("@client.Email", client.Email);
                cmd.Parameters.AddWithValue("@client.Phone", client.Phone);
                cmd.Parameters.AddWithValue("@client.Address", client.Address);

                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("El rut del cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }

        }

        public static Clients findClient(string rut)
        {
            Clients client = new Clients();
            MySqlConnection connection = Connection.getConnection();
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT rut, names, last_names, email, phone, address FROM client WHERE rut='{0}'", rut), connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!Convert.IsDBNull(reader["rut"]))
                {
                    client.Rut = reader.GetString(0);
                }
                else
                {
                    client.Rut = string.Empty;
                }
                if (!Convert.IsDBNull(reader["names"])){
                    client.Name = reader.GetString(1);
                }
                else
                {
                    client.Name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["last_names"]))
                {
                    client.Last_name = reader.GetString(2);
                }
                else
                {
                    client.Last_name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["email"]))
                {
                    client.Email = reader.GetString(3);
                }
                else
                {
                    client.Email = string.Empty;
                }

                if (Convert.ToInt32(reader["phone"]) != 0)
                {
                    client.Phone = reader.GetInt32(4);
                }
                else
                {
                    client.Phone = 0;
                }

                if (!Convert.IsDBNull(reader["address"]))
                {
                    client.Address = reader.GetString(5);
                }
                else
                {
                    client.Address = string.Empty;
                }

            }
            connection.Close();
            return client;

        }

        public static int getTotalClient(DateTime date)
        {
            MySqlConnection conexion = Connection.getConnection();
            string Query = "SELECT COUNT(*) FROM sale WHERE cashbox_date=?date AND client!=?client";
            string Query1 = "SELECT COUNT(*) FROM work_order WHERE cashbox_date=?date AND client!=?client";

            MySqlCommand comando = new MySqlCommand(Query, conexion);
            MySqlCommand comando1 = new MySqlCommand(Query1, conexion);
            comando.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            comando.Parameters.AddWithValue("?client", "00000000");

            comando1.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            comando1.Parameters.AddWithValue("?client", "00000000");

            int value = Convert.ToInt32(comando.ExecuteScalar());
            int value1 = Convert.ToInt32(comando1.ExecuteScalar());
            value = value + value1;
            conexion.Close();
            return value;
        }
      
        public static List<Clients> listClient()
        {
            List<Clients> _list = new List<Clients>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT rut,names,last_names,email,phone,address FROM client WHERE rut!={0}",00000000), Connection.getConnection());
            MySqlDataReader reader = _comando.ExecuteReader();

            while (reader.Read())
            {
                Clients client = new Clients();

                if (!Convert.IsDBNull(reader["rut"]))
                {
                    client.Rut = reader.GetString(0);
                }
                else
                {
                    client.Rut = string.Empty;
                }
                if (!Convert.IsDBNull(reader["names"]))
                {
                    client.Name = reader.GetString(1);
                }
                else
                {
                    client.Name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["last_names"]))
                {
                    client.Last_name = reader.GetString(2);
                }
                else
                {
                    client.Last_name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["email"]))
                {
                    client.Email = reader.GetString(3);
                }
                else
                {
                    client.Email = string.Empty;
                }

                if (Convert.ToInt32(reader["phone"]) != 0)
                {
                    client.Phone = reader.GetInt32(4);
                }
                else
                {
                    client.Phone = 0;
                }

                if (!Convert.IsDBNull(reader["address"]))
                {
                    client.Address = reader.GetString(5);
                }
                else
                {
                    client.Address = string.Empty;
                }

                _list.Add(client);
            }

            return _list;
        }

        public static List<Clients> findClients(string text)
        {

            MySqlCommand cmd;
            List<Clients> _list = new List<Clients>();
            MySqlConnection connection = Connection.getConnection();
            cmd = new MySqlCommand(string.Format("Select * FROM client WHERE rut LIKE('%{0}%') AND rut!={1}",text, 00000000), connection);

              

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Clients client = new Clients();

                if (!Convert.IsDBNull(reader["rut"]))
                {
                    client.Rut = reader.GetString(0);
                }
                else
                {
                    client.Rut = string.Empty;
                }
                if (!Convert.IsDBNull(reader["names"]))
                {
                    client.Name = reader.GetString(1);
                }
                else
                {
                    client.Name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["last_names"]))
                {
                    client.Last_name = reader.GetString(2);
                }
                else
                {
                    client.Last_name = string.Empty;
                }

                if (!Convert.IsDBNull(reader["email"]))
                {
                    client.Email = reader.GetString(3);
                }
                else
                {
                    client.Email = string.Empty;
                }

                if (Convert.ToInt32(reader["phone"]) != 0)
                {
                    client.Phone = reader.GetInt32(4);
                }
                else
                {
                    client.Phone = 0;
                }

                if (!Convert.IsDBNull(reader["address"]))
                {
                    client.Address = reader.GetString(5);
                }
                else
                {
                    client.Address = string.Empty;
                }

                _list.Add(client);
            }
            connection.Close();
            return _list;
        }
     //-------------- CRUD USER ---------------------------------------
        //Get one user for username
        public static User getUser(string username)
        {
            User user = new User();
            MySqlConnection connection = Connection.getConnection();
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT username, password FROM user WHERE username='{0}'", username), connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.Username = reader.GetString(0);
                user.Password = reader.GetString(1);
            }
            connection.Close();
            return user;

        }
        public static List<User> listUsers()
        {

            List<User> _list = new List<User>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT username,password FROM user"), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                User Usr = new User();
                Usr.Username = _reader.GetString(0);
                Usr.Password = _reader.GetString(1);
                _list.Add(Usr);
            }

            return _list;

        }
        public static int addUser(User user)
        {
            int retorno = 0;

            try
            {
                string encrypt_pass = Utils.Encrypt(user.Password);
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into user (username, password) values ('{0}','{1}')",
                user.Username,encrypt_pass), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(e);
                return retorno;
            }
        }
        public static int updateUser(User user,string old_pass, string new_pass)
        {
            string decryp_pass = Utils.Decrypt(user.Password);
            int retorno = 0;
            if (decryp_pass == old_pass)
            {
                try
                {
                    new_pass = Utils.Encrypt(new_pass);
                    MySqlConnection conexion = Connection.getConnection();
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE user SET password='{0}' WHERE username='{1}'", new_pass, user.Username), conexion);
                    retorno = comando.ExecuteNonQuery();
                    conexion.Close();
                    return retorno;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show("No se pudo editar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return retorno;
                }

            }
            else
            {
                MessageBox.Show("La contraseña antigua no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
            
        }

        //------------- CRUD PROVIDER ------------------------------------
        //Get one provider for Id
        public static Provider getProvider(int Id)
        {
            Provider provider = new Provider();
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT name FROM provider where id={0}", Id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                provider.Name = _reader.GetString(0);
            }
            conexion.Close();
            return provider;

        }
        //Add provider
        public static int addProvider(Provider prv)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into provider (name, phone, email, address, city) values ('{0}','{1}','{2}', '{3}', '{4}')",
                prv.Name, prv.Phone, prv.Email, prv.Address, prv.City), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
        //Get all providers
        public static List<Provider> listProviders()
        {
            int active = 1;
            List<Provider> _list = new List<Provider>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, name, phone, email, address, city, active FROM provider WHERE active={0}",active), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Provider Prv = new Provider();
                Prv.Id = _reader.GetInt32(0);
                Prv.Name = _reader.GetString(1);
                Prv.Phone = _reader.GetInt32(2);
                Prv.Email = _reader.GetString(3);
                Prv.Address = _reader.GetString(4);
                Prv.City = _reader.GetString(5);
                Prv.Active = _reader.GetInt32(6);


                _list.Add(Prv);
            }

            return _list;
        }
        //Update one provider
        public static List<Provider> listDisableProviders()
        {
            int inactive = 0;
            List<Provider> _list = new List<Provider>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, name, phone, email, address, city, active FROM provider WHERE active={0}", inactive), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Provider Prv = new Provider();
                Prv.Id = _reader.GetInt32(0);
                Prv.Name = _reader.GetString(1);
                Prv.Phone = _reader.GetInt32(2);
                Prv.Email = _reader.GetString(3);
                Prv.Address = _reader.GetString(4);
                Prv.City = _reader.GetString(5);
                Prv.Active = _reader.GetInt32(6);


                _list.Add(Prv);
            }

            return _list;

        }
        public static int updateProvider(Provider provider)
        {
            int retorno = 0;
            try
            {

                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE provider SET name='{0}', phone='{1}', email='{2}', address='{3}', city='{4}' WHERE id='{5}'",provider.Name, provider.Phone, provider.Email, provider.Address, provider.City, provider.Id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo editar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }

        //Search provider products
        public static List<Product> providersProducts(int provider_id)
        {
            int active = 1;
            List<Product> _list = new List<Product>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, name, difference, provider, active FROM product WHERE active={0} AND provider={1}", active, provider_id), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Product prod = new Product();
                prod.Codigo = _reader.GetString(0);
                prod.Nombre = _reader.GetString(1);
                prod.Precio_compra = 0;
                prod.Precio_venta = 0;
                prod.Tipo = 0;
                prod.Cantidad_actual = 0;
                prod.Cantidad_deseada = 0;
                prod.Categoria = 0;
                prod.Cantidad_faltante = _reader.GetInt32(2);
                prod.Proveedor = _reader.GetInt32(3);
                prod.Activo = _reader.GetInt32(4);


                _list.Add(prod);
            }

            return _list;
        }
        //Delete one provider
        /**public static int deleteProvider(int id)
        {
            int retorno = 0;
            try
            {
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE from provider WHERE id='{0}'", id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception k)
            {
                MessageBox.Show("No se pudo eliminar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }


        }**/
        public static int disableProvider(int id)
        {
            int retorno = 0;
            try
            {
                int active = 0;
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE provider SET active='{0}' WHERE id='{1}'",active,id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo deshabilitar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }

        }
        public static int enableProvider(int id)
        {
            int retorno = 0;
            try
            {
                int active = 1;
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE provider SET active='{0}' WHERE id='{1}'", active, id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo habilitar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }

        }
        public static List<Provider> findProvider(string param)
        {
            MySqlCommand cmd;
            int active = 1;
            List<Provider> _list = new List<Provider>();
            MySqlConnection connection = Connection.getConnection();
            cmd = new MySqlCommand(string.Format("Select * FROM provider WHERE name LIKE('%{0}%') AND active={1}", param,active), connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Provider prv = new Provider();
                prv.Id = reader.GetInt32(0);
                prv.Name = reader.GetString(1);
                prv.Phone = reader.GetInt32(2);
                prv.Email = reader.GetString(3);
                prv.Address = reader.GetString(4);
                prv.City = reader.GetString(5);
                prv.Active = reader.GetInt32(6);
                
                _list.Add(prv);
            }
            connection.Close();
            return _list;

        }
        //------------- CRUD TYPE ---------------------------------------
        //Get one type for Id
        public static Type getType(int Id)
        {
            Type type = new Type();
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT name FROM type where id={0}", Id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                type.Name = _reader.GetString(0);
            }
            conexion.Close();
            return type;
        }
        //Add type
        public static int addType(Type type)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into type (name) values ('{0}')", type.Name), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo agregar el tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
        //------------- CRUD CATEGORY -----------------------------------
        //Add category
        public static int addCategory(Category category)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into category (name) values ('{0}')", category.Name), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo agregar la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
        //Get one category for Id
        public static Category getCategory(int Id)
        {
            Category category = new Category();
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT name FROM category where id={0}", Id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                category.Name = _reader.GetString(0);
            }
            conexion.Close();
            return category;

        }
        //------------ CRUD PRODUCT -------------------------------------
        //Add product
        public static int addProduct(Product product)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into product (id, name, sale_price, buyed_price, stock, desired, provider, category, type) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", product.Codigo, product.Nombre, product.Precio_venta, product.Precio_compra, product.Cantidad_actual, product.Cantidad_deseada, product.Proveedor, product.Categoria, product.Tipo), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;

            }
            catch (Exception e)
            {
                MessageBox.Show("El código del producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(e);
                return retorno;

            }
        }
        //Get all products
        public static List<Product_Display> listProducts(string estado)
        {
            int active = 1;
            int stock = 0;
            MySqlCommand _comando;
            Provider prv = new Provider();
            Category ctg = new Category();
            Type type = new Type();
            List<Product_Display> _list = new List<Product_Display>();
            if(estado == "products")
            {
                _comando = new MySqlCommand(String.Format("Select id, name, sale_price, buyed_price, stock, desired, difference, provider, category,type, active FROM product WHERE active={0}", active), Connection.getConnection());
                
            }
            else
            {
                _comando = new MySqlCommand(String.Format("Select id, name, sale_price, buyed_price, stock, desired, difference, provider, category, type, active FROM product WHERE active={0} and stock >{1}", active, stock), Connection.getConnection());

            }

            MySqlDataReader _reader = _comando.ExecuteReader();
            Console.WriteLine(_reader);
            while (_reader.Read())
            {

                Product_Display product = new Product_Display();
                product.Codigo = _reader.GetString(0);
                product.Nombre = _reader.GetString(1);
                product.Precio_venta = _reader.GetInt32(2);
                product.Precio_compra = _reader.GetInt32(3);
                product.Cantidad_actual = _reader.GetInt32(4);
                product.Cantidad_deseada = _reader.GetInt32(5);
                product.Cantidad_faltante = _reader.GetInt32(6);
                prv = getProvider(_reader.GetInt32(7));
                product.Proveedor = prv.Name;
                ctg = getCategory(_reader.GetInt32(8));
                product.Categoria = ctg.Name;
                type = getType(_reader.GetInt32(9));
                product.Tipo = type.Name;
                product.Active = _reader.GetInt32(10);

                _list.Add(product);
            }
            Connection.getConnection().Close();
            return _list;
        }

        public static Int32 getTotalSales(DateTime date_from, DateTime date_until)
        {
            MySqlConnection connection = Connection.getConnection();
            string Query = "SELECT SUM(total_account), cashbox_date FROM sale WHERE cashbox_date BETWEEN ?date1 AND ?date2";
            MySqlCommand comando = new MySqlCommand(Query, connection);

            comando.Parameters.AddWithValue("?date1", date_from.ToString("s").Substring(0, 10));
            comando.Parameters.AddWithValue("?date2", date_until.ToString("s").Substring(0, 10));
            MySqlDataReader reader = comando.ExecuteReader();
            Int32 total = new Int32();
            while (reader.Read())
            {
                total = reader.GetInt32(0);
            }
            connection.Close();
            return total;
        }

        public static List<Sales> findSalesToFile(DateTime date_from, DateTime date_until)
        {
            Sales sale = new Sales();
            List<Sales> tmp_list = new List<Sales>();
            MySqlConnection connection = Connection.getConnection();
            string Query = "SELECT id, date, total_account, username FROM sale WHERE cashbox_date BETWEEN ?date1 AND ?date2 ORDER BY date ASC";

            MySqlCommand comando = new MySqlCommand(Query, connection);

            comando.Parameters.AddWithValue("?date1", date_from.ToString("s").Substring(0, 10));
            comando.Parameters.AddWithValue("?date2", date_until.ToString("s").Substring(0, 10));

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(0));
                //Console.WriteLine(reader.GetValue(1));
                Sales aux = new Sales();
                aux.id = reader.GetInt32(0);
                aux.date = reader.GetDateTime(1);
                aux.total_account = reader.GetInt32(2);
                //aux.payment_method = reader.GetInt32(3);
                //aux.cashbox_date = reader.GetDateTime(1);
                //aux.client = reader.GetString(5);
                aux.username = reader.GetString(3);

                tmp_list.Add(aux);
            }
            connection.Close();
            return tmp_list;

        }

        public static List<Sales> findAllSales()
        {
            Sales sale = new Sales();
            List<Sales> tmp_list = new List<Sales>();
            MySqlConnection connection = Connection.getConnection();
            string Query = "SELECT SUM(total_account), cashbox_date FROM sale WHERE cashbox_date GROUP BY cashbox_date ORDER BY cashbox_date ASC";

            MySqlCommand comando = new MySqlCommand(Query, connection);

            //Console.WriteLine(Query);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(0));
                //Console.WriteLine(reader.GetValue(1));
                Sales aux = new Sales();
                //aux.date = reader.GetDateTime(1);
                aux.total_account = reader.GetInt32(0);
                //aux.payment_method = reader.GetInt32(3);
                aux.cashbox_date = reader.GetDateTime(1);
                //aux.client = reader.GetString(5);
                //aux.username = reader.GetString(6);

                tmp_list.Add(aux);
            }
            connection.Close();
            return tmp_list;
        }
        public static List<Sales> findSales(DateTime date_from, DateTime date_until)
        {
            Sales sale = new Sales();
            List<Sales> tmp_list = new List<Sales>();
            MySqlConnection connection = Connection.getConnection();
            string Query = "SELECT SUM(total_account), cashbox_date FROM sale WHERE cashbox_date BETWEEN ?date1 AND ?date2 GROUP BY cashbox_date ORDER BY cashbox_date ASC";

            MySqlCommand comando = new MySqlCommand(Query, connection);

            comando.Parameters.AddWithValue("?date1", date_from.ToString("s").Substring(0, 10));
            comando.Parameters.AddWithValue("?date2", date_until.ToString("s").Substring(0, 10));
            //Console.WriteLine(Query);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(0));
                //Console.WriteLine(reader.GetValue(1));
                Sales aux = new Sales();
                //aux.date = reader.GetDateTime(1);
                aux.total_account = reader.GetInt32(0);
                //aux.payment_method = reader.GetInt32(3);
                aux.cashbox_date = reader.GetDateTime(1);
                //aux.client = reader.GetString(5);
                //aux.username = reader.GetString(6);

                tmp_list.Add(aux);
            }
            connection.Close();
            return tmp_list;
        }
        //Get products list for string in field name or field code
        public static List<Product_Display> findProduct(string param, string campo, string estado)
        {
            int active = 1;
            int stock = 0;
            MySqlCommand cmd;
            Provider prv = new Provider();
            Category ctg = new Category();
            Type type = new Type();
            List<Product_Display> _list = new List<Product_Display>();
            MySqlConnection connection = Connection.getConnection();
            if (campo == "id" )
            {
                if(estado == "products")
                {
                    
                    cmd = new MySqlCommand(string.Format("Select * FROM product WHERE id LIKE('%{0}%') AND active={1}", param, active), connection);
                }
                else
                {
                    cmd = new MySqlCommand(string.Format("Select * FROM product WHERE id LIKE('%{0}%') AND active={1} AND stock>{2}", param, active,stock), connection);
                } 

            }
            else
            {
                if(estado == "products")
                {
                    cmd = new MySqlCommand(string.Format("Select * FROM product WHERE name LIKE('%{0}%')  AND active={1}", param, active), connection);
                }
                else
                {
                    cmd = new MySqlCommand(string.Format("Select * FROM product WHERE name LIKE('%{0}%')  AND active={1} AND stock>{2}", param, active,stock), connection);
                }
                
            }

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product_Display product = new Product_Display();
                product.Codigo = reader.GetString(0);
                product.Nombre = reader.GetString(1);
                product.Precio_venta = reader.GetInt32(2);
                product.Precio_compra = reader.GetInt32(3);
                product.Cantidad_actual = reader.GetInt32(4);
                product.Cantidad_deseada = reader.GetInt32(5);
                product.Cantidad_faltante = reader.GetInt32(6);
                prv = getProvider(reader.GetInt32(7));
                product.Proveedor = prv.Name;
                ctg = getCategory(reader.GetInt32(8));
                product.Categoria = ctg.Name;
                type = getType(reader.GetInt32(9));
                product.Tipo = type.Name;
                product.Active = reader.GetInt32(10);

                _list.Add(product);
            }
            connection.Close();
            return _list;

        }
        //Update one product
        public static int updateProduct(Product product)
        {
            int retorno = 0;
            try
            {
                
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE product SET name='{0}', sale_price='{1}', buyed_price='{2}', stock='{3}', desired='{4}', provider='{5}', category='{6}', type='{7}' WHERE id='{8}'", product.Nombre, product.Precio_venta, product.Precio_compra, product.Cantidad_actual, product.Cantidad_deseada, product.Proveedor, product.Categoria, product.Tipo, product.Codigo), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo editar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
            
        }


        public static int updateStockProduct(string code, int stock)
        {
            int retorno = 0;
            try
            {
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE product SET  stock=stock-'{0}' WHERE id='{1}'",stock,code), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error en actualizar stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }

        public static int updateAddStockProduct(string code, int stock)
        {
            int retorno = 0;
            try
            {
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE product SET  stock=stock+'{0}' WHERE id='{1}'", stock, code), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error en actualizar stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
   
        public static int disableProduct(string id)
        {
            int retorno = 0;
            try
            {
                int active = 0;
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE product SET active='{0}' WHERE id='{1}'", active, id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo deshabilitar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
        public static int enableProduct(string id)
        {
            int retorno = 0;
            try
            {
                int active = 1;
                MySqlConnection conexion = Connection.getConnection();
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE product SET active='{0}' WHERE id='{1}'", active, id), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("No se pudo habilitar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
        public static List<Product_Display> listDisableProduct()
        {
            int inactive = 0 ;
            Provider prv = new Provider();
            Category ctg = new Category();
            Type type = new Type();
            List<Product_Display> _list = new List<Product_Display>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "Select id, name, sale_price, buyed_price, stock, desired, difference, provider, category,type, active FROM product WHERE active={0}", inactive), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                Product_Display product = new Product_Display();
                product.Codigo = _reader.GetString(0);
                product.Nombre = _reader.GetString(1);
                product.Precio_venta = _reader.GetInt32(2);
                product.Precio_compra = _reader.GetInt32(3);
                product.Cantidad_actual = _reader.GetInt32(4);
                product.Cantidad_deseada = _reader.GetInt32(5);
                product.Cantidad_faltante = _reader.GetInt32(6);
                prv = getProvider(_reader.GetInt32(7));
                product.Proveedor = prv.Name;
                ctg = getCategory(_reader.GetInt32(8));
                product.Categoria = ctg.Name;
                type = getType(_reader.GetInt32(9));
                product.Tipo = type.Name;
                product.Active = _reader.GetInt32(10);

                _list.Add(product);
            }
            return _list;
        }
        public static Product getProduct(string code)
        {
            Product product = new Product();
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT sale_price, stock, desired, difference FROM product where id='{0}'", code), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                product.Precio_venta = _reader.GetInt32(0);
                product.Cantidad_actual = _reader.GetInt32(1);
                product.Cantidad_deseada = _reader.GetInt32(2);
                product.Cantidad_faltante = _reader.GetInt32(3);
            }
            conexion.Close();
            return product;
        }

        public static int getTotalProduct(DateTime date)
        {
            MySqlConnection conexion = Connection.getConnection();
            string Query = "SELECT COUNT(*) FROM detail INNER JOIN sale ON detail.sale = sale.id AND sale.cashbox_date=?date";
            string Query1 = "SELECT COUNT(*) FROM detail_work_order INNER JOIN work_order ON detail_work_order.work_order = work_order.id AND work_order.cashbox_date=?date";

            MySqlCommand comando = new MySqlCommand(Query, conexion);
            MySqlCommand comando1 = new MySqlCommand(Query1, conexion);
            comando.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            comando1.Parameters.AddWithValue("?date", date.ToString("s").Substring(0, 10));
            int value = Convert.ToInt32(comando.ExecuteScalar());
            int value1 = Convert.ToInt32(comando1.ExecuteScalar());
            value = value + value1;
            conexion.Close();
            return value;
        }
        //------------ CRUD PAYMENT_METHOD -------------------------------------
        public static List<Payment_method> getPayment_Methods()
        {
            List<Payment_method> _list = new List<Payment_method>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id, type FROM payment_method"), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Payment_method py_met = new Payment_method();
                py_met.Id = _reader.GetInt32(0);
                py_met.Type = _reader.GetString(1);

                _list.Add(py_met);
            }

            return _list;
        }

        public static string getPayment_Method(int id)
        {
            string type=string.Empty;
            MySqlConnection conexion = Connection.getConnection();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT type FROM payment_method where id={0}", id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                type = _reader.GetString(0);
            }
            conexion.Close();
            return type;

        }

    }
}
