using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml.Linq;

namespace laba_8
{
    public static class WorkWithBD
    {

        public static List<Airplane> airplanes = new List<Airplane>();
        private static SqlConnection connection;
        public static  void Connection()
        {
            string connectionString = "Data Source = DESKTOP-DDFE5SO\\SQLEXPRESS;Database=AIR; Integrated Security = true; Connect Timeout = 30";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public static void CLoseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
        }


        public static  void GetAll(DataGrid grid)
        {

            string sqlCommand = "SELECT * FROM Airplane";
            try
            {
                Connection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                grid.ItemsSource = data.Tables[0].DefaultView;
                foreach (DataRow item in data.Tables[0].Rows)
                {
                    Airplane airplane = new Airplane(Int32.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), Int32.Parse(item[3].ToString()), item[4].ToString(), Int32.Parse(item[5].ToString()), item[6].ToString(), item[7].ToString());
                    airplanes.Add(airplane);
                }
                CLoseConnection();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
        }


        public static void Sort(String whatSort,DataGrid grid)
        {
            string zapros = "Select * from Airplane order by " + whatSort.ToString();

            Connection();
            SqlCommand cmd = new SqlCommand(zapros, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            airplanes.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Airplane airplane = new Airplane(Int32.Parse(reader.GetValue(0).ToString()), (string)reader.GetValue(1), (string)reader.GetValue(2), (int)reader.GetValue(3), (string)reader.GetValue(4), (int)reader.GetValue(5), (string)reader.GetValue(6), (string)reader.GetValue(7));
                    airplanes.Add(airplane);
                }
            }
            grid.ItemsSource = null;
            grid.ItemsSource = airplanes;
            CLoseConnection();
        }


        public static void Insert(Airplane addAirplane)
        {
            try
            {
                Connection();
                string zapros = "insert Airplane(id,type,model,freePlace,dataCreate,maxWeight,dateLastOsm,img) values( @idd, @type, @model,@free,@dataC,@maxW,@dateL,@img)";
                SqlCommand command = new SqlCommand(zapros, connection);
                SqlParameter id = new SqlParameter("@idd", addAirplane.id);
                SqlParameter type = new SqlParameter("@type", addAirplane.type);
                SqlParameter model = new SqlParameter("@model", addAirplane.model);
                SqlParameter freePlace = new SqlParameter("@free", addAirplane.freePlace);
                SqlParameter dataCreate = new SqlParameter("@dataC", addAirplane.dataCreate);
                SqlParameter maxWeight = new SqlParameter("@maxW", addAirplane.maxWeight);
                SqlParameter dateLastOsm = new SqlParameter("@dateL", addAirplane.dateLastOsm);
                SqlParameter img = new SqlParameter("@img", addAirplane.img);
                command.Parameters.Add(id);
                command.Parameters.Add(type);
                command.Parameters.Add(model);
                command.Parameters.Add(freePlace);
                command.Parameters.Add(dataCreate);
                command.Parameters.Add(maxWeight);
                command.Parameters.Add(dateLastOsm);
                command.Parameters.Add(img);
                int number = command.ExecuteNonQuery();
                CLoseConnection();
                airplanes.Add(addAirplane);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
        }

        public static void Delete(int id)
        {
            try
            {
                Connection();
                string zapros = "delete Airplane where id = @id";
                SqlCommand command = new SqlCommand(zapros,connection);
                SqlParameter parameter = new SqlParameter("@id", id);
                command.Parameters.Add(parameter);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Airplane airplane = new Airplane(Int32.Parse(reader.GetValue(0).ToString()), (string)reader.GetValue(1), (string)reader.GetValue(2), (int)reader.GetValue(3), (string)reader.GetValue(4), (int)reader.GetValue(5), (string)reader.GetValue(6), (string)reader.GetValue(7));
                    airplanes.Remove(airplane);
                }
                CLoseConnection();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }


        public static void GetZapros(string zapros, DataGrid grid)
        {
            Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(zapros, connection);
            DataSet data = new DataSet();
            sqlDataAdapter.Fill(data);
            grid.ItemsSource = data.Tables[0].DefaultView;
            airplanes.Clear();
            foreach (DataRow item in data.Tables[0].Rows)
            {
                Airplane airplane = new Airplane(Int32.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), Int32.Parse(item[3].ToString()), item[4].ToString(), Int32.Parse(item[5].ToString()), item[6].ToString(), item[7].ToString());
                airplanes.Add(airplane);
            }
            CLoseConnection();
        }

        public static void Update(Airplane newAirplane)
        {
            try
            {

                Connection();
                string zapros = "update Airplane set id=@id,type = @tp,model = @mo,freePlace = @fr,dataCreate = @dc,maxWeight = @mw,dateLastOsm = @dal,img = @img where id = @id";
                SqlCommand command = new SqlCommand(zapros, connection);
                SqlParameter id = new SqlParameter("@id", newAirplane.id);
                SqlParameter type = new SqlParameter("@tp", newAirplane.type);
                SqlParameter model = new SqlParameter("@mo", newAirplane.model);
                SqlParameter freePlace = new SqlParameter("@fr", newAirplane.freePlace);
                SqlParameter dataCreate = new SqlParameter("@dc", newAirplane.dataCreate);
                SqlParameter maxWeight = new SqlParameter("@mw", newAirplane.maxWeight);
                SqlParameter dateLastOsm = new SqlParameter("@dal", newAirplane.dateLastOsm);
                SqlParameter img = new SqlParameter("@img", newAirplane.img);
                command.Parameters.Add(id);
                command.Parameters.Add(type);
                command.Parameters.Add(model);
                command.Parameters.Add(freePlace);
                command.Parameters.Add(dataCreate);
                command.Parameters.Add(maxWeight);
                command.Parameters.Add(dateLastOsm);
                command.Parameters.Add(img);
                SqlDataReader reader = command.ExecuteReader();
                Airplane airplane = new Airplane(newAirplane.id, newAirplane.type, newAirplane.model, newAirplane.freePlace, newAirplane.dataCreate, newAirplane.maxWeight, newAirplane.dateLastOsm, newAirplane.img);
                WorkWithBD.airplanes[newAirplane.id-1] = airplane;
                CLoseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
