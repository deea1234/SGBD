using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sgbd1
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=DESKTOP-TCVJSKD\\SQLEXPRESS;Initial Catalog=Cofetarie;Integrated Security=True;TrustServerCertificate=true;";

        SqlDataAdapter employeeAdapter;
        SqlDataAdapter storeAdapter;

        DataSet ds = new DataSet();
        BindingSource bsEmployee;
        BindingSource bsStore;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Starea conexiunii: " + connection.State.ToString());     
                           storeAdapter = new SqlDataAdapter("SELECT * FROM Cofetarie;", connection);
                            employeeAdapter = new SqlDataAdapter("SELECT * FROM Angajati;", connection);


                            storeAdapter.Fill(ds, "Cofetarie");
                            employeeAdapter.Fill(ds, "Angajati");

                            bsStore = new BindingSource();
                            bsStore.DataSource = ds.Tables["Cofetarie"];
                            dataGridView1.DataSource = bsStore;

                            DataColumn storeColumn = ds.Tables["Cofetarie"].Columns["id_cofetarie"];
                            DataColumn employeeColumn = ds.Tables["Angajati"].Columns["Id_cofetarie"];
                            DataRelation relation = new DataRelation("FK_Cofetarie_Angajati", storeColumn, employeeColumn);

                            ds.Relations.Add(relation);

                            bsEmployee = new BindingSource();
                            bsEmployee.DataSource = bsStore;
                            bsEmployee.DataMember = "FK_Cofetarie_Angajati";
                            dataGridView2.DataSource = bsEmployee;

                    textBox4.DataBindings.Add("Text", bsEmployee, "id_cofetarie", true);
                    textBox2.DataBindings.Add("Text", bsEmployee, "id_angajat", true);
                    textBox3.DataBindings.Add("Text", bsEmployee, "nume_angajat", true);
                    textBox1.DataBindings.Add("Text", bsEmployee, "salar", true);

                    if (dataGridView2.Rows[0].Cells["nume_angajat"] == null)
                    {
                        // Clear text boxes
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox1.Text = "";
                        textBox4.DataBindings.Add("Text", bsEmployee, "id_cofetarie", true);

                    }
                   

                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {   

                    storeAdapter.SelectCommand.Connection = connection;
                    employeeAdapter.SelectCommand.Connection = connection;

                    employeeAdapter.InsertCommand = new SqlCommand("INSERT INTO Angajati(nume_angajat, salar, id_cofetarie) VALUES (@nume, @salar, @id_cofetarie)", connection);

                   
                    employeeAdapter.InsertCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = textBox3.Text;
                    employeeAdapter.InsertCommand.Parameters.Add("@salar", SqlDbType.VarChar).Value = Int32.Parse(textBox1.Text);
                    employeeAdapter.InsertCommand.Parameters.Add("@id_cofetarie", SqlDbType.Int).Value = Int32.Parse(textBox4.Text);


                    connection.Open();
                    employeeAdapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully.");
                    connection.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshed!");
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        storeAdapter = new SqlDataAdapter("SELECT * FROM Cofetarie;", connection);
                        employeeAdapter = new SqlDataAdapter("SELECT * FROM Angajati;", connection);

                        ds.Clear();

                        storeAdapter.Fill(ds, "Cofetarie");
                        employeeAdapter.Fill(ds, "Angajati");


                        dataGridView1.DataSource = bsStore;
                        dataGridView2.DataSource = bsEmployee;

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.");
                }
            
            }

        private void DeleteAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    storeAdapter.SelectCommand.Connection = connection;
                    employeeAdapter.SelectCommand.Connection = connection;

                    employeeAdapter.DeleteCommand = new SqlCommand("DELETE FROM Angajati WHERE id_angajat = @id", connection);

                    employeeAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBox2.Text);
                    

                    connection.Open();
                    employeeAdapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully.");
                    connection.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    storeAdapter.SelectCommand.Connection = connection;
                    employeeAdapter.SelectCommand.Connection = connection;

                    employeeAdapter.UpdateCommand = new SqlCommand("UPDATE Angajati SET nume_angajat = @nume, salar=@salar , id_cofetarie=@id_cofetarie WHERE id_angajat = @id"  , connection);


                    employeeAdapter.UpdateCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = textBox3.Text;
                    employeeAdapter.UpdateCommand.Parameters.Add("@salar", SqlDbType.Int).Value = Int32.Parse(textBox1.Text);
                    employeeAdapter.UpdateCommand.Parameters.Add("@id_cofetarie", SqlDbType.Int).Value = Int32.Parse(textBox4.Text);
                    employeeAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(textBox2.Text);


                    connection.Open();
                    employeeAdapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully.");
                    connection.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

    }
}