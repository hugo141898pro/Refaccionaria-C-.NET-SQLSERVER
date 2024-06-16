using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace tarea_de_base;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

    private System.Windows.Forms.Label tituloNombre;
    private System.Windows.Forms.TextBox nombre;
    private System.Windows.Forms.Label TituloAlmacenaje;
    private System.Windows.Forms.TextBox tonelajeDeAlmacenaje;
    private System.Windows.Forms.Label tituloPlaca;
    private System.Windows.Forms.TextBox placas;
    private System.Windows.Forms.Label tituloMarca;
    private System.Windows.Forms.TextBox marca;
    private System.Windows.Forms.Button enviar;
    private DataGridView dataGridView;

    // buscar

    private System.Windows.Forms.Label tituloBuscar;
    private System.Windows.Forms.TextBox buscar;
    private System.Windows.Forms.Button MandarBusqueda;
    private System.Windows.Forms.Label Buscado;
    


    //BD
    private SqlConnection sqlConnection;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1350, 450);
        this.Text = "Refaccionaria";

        //Nombre

        tituloNombre = new System.Windows.Forms.Label();
        tituloNombre.Text = "Nombre";
        tituloNombre.ForeColor = Color.Blue;
        tituloNombre.BackColor = Color.Bisque;
        tituloNombre.Location = new System.Drawing.Point(40, 40);
        tituloNombre.Size = new System.Drawing.Size(100, 30);
        tituloNombre.Font = new Font("Impact", 14);
        this.Controls.Add(tituloNombre);

        nombre = new System.Windows.Forms.TextBox();
        nombre.ForeColor = Color.Red;
        nombre.Location = new System.Drawing.Point(40, 80);
        nombre.Size = new System.Drawing.Size(100, 30);
        nombre.Font = new Font("Arial", 12);
        this.Controls.Add(nombre);

        // tonelaje De Almacenaje

        TituloAlmacenaje = new System.Windows.Forms.Label();
        TituloAlmacenaje.Text = "Tonelada de almacenaje";
        TituloAlmacenaje.ForeColor = Color.Blue;
        TituloAlmacenaje.BackColor = Color.Bisque;
        TituloAlmacenaje.Location = new System.Drawing.Point(200, 40);
        TituloAlmacenaje.Size = new System.Drawing.Size(265, 30);
        TituloAlmacenaje.Font = new Font("Impact", 14);
        this.Controls.Add(TituloAlmacenaje);

        tonelajeDeAlmacenaje = new System.Windows.Forms.TextBox();
        tonelajeDeAlmacenaje.ForeColor = Color.Red;
        tonelajeDeAlmacenaje.Location = new System.Drawing.Point(200, 80);
        tonelajeDeAlmacenaje.Size = new System.Drawing.Size(100, 30);
        tonelajeDeAlmacenaje.Font = new Font("Arial", 12);
        this.Controls.Add(tonelajeDeAlmacenaje);

        //Placa

        tituloPlaca = new System.Windows.Forms.Label();
        tituloPlaca.Text = "Placa";
        tituloPlaca.ForeColor = Color.Blue;
        tituloPlaca.BackColor = Color.Bisque;
        tituloPlaca.Location = new System.Drawing.Point(40, 150);
        tituloPlaca.Size = new System.Drawing.Size(100, 30);
        tituloPlaca.Font = new Font("Impact", 14);
        this.Controls.Add(tituloPlaca);

        placas = new System.Windows.Forms.TextBox();
        placas.ForeColor = Color.Red;
        placas.Location = new System.Drawing.Point(40, 200);
        placas.Size = new System.Drawing.Size(100, 30);
        placas.Font = new Font("Arial", 12);
        this.Controls.Add(placas);

        //marca

        tituloMarca = new System.Windows.Forms.Label();
        tituloMarca.Text = "Marca";
        tituloMarca.ForeColor = Color.Blue;
        tituloMarca.BackColor = Color.Bisque;
        tituloMarca.Location = new System.Drawing.Point(200, 150);
        tituloMarca.Size = new System.Drawing.Size(100, 30);
        tituloMarca.Font = new Font("Impact", 14);
        this.Controls.Add(tituloMarca);

        marca = new System.Windows.Forms.TextBox();
        marca.ForeColor = Color.Red;
        marca.Location = new System.Drawing.Point(200, 200);
        marca.Size = new System.Drawing.Size(100, 30);
        marca.Font = new Font("Arial", 12);
        this.Controls.Add(marca);

        // boton
    
        enviar = new System.Windows.Forms.Button();
        enviar.Text = "Enviar";
        enviar.ForeColor = Color.Blue;
        enviar.Location = new System.Drawing.Point(125, 270);
        enviar.Size = new System.Drawing.Size(100, 30);
        enviar.Font = new Font("Impact", 14);
        this.Controls.Add(enviar);
        enviar.Click += EnviarDatos;

        //DataGridView
        dataGridView = new DataGridView();
        dataGridView.Location = new Point(400, 100);
        dataGridView.Size = new Size(350, 200);
        this.Controls.Add(dataGridView);

        this.Load += Form1_Load;

        // buscar

        tituloBuscar = new System.Windows.Forms.Label();
        tituloBuscar.Text = "Buscar por ID";
        tituloBuscar.ForeColor = Color.Blue;
        tituloBuscar.BackColor = Color.Bisque;
        tituloBuscar.Location = new System.Drawing.Point(800, 100);
        tituloBuscar.Size = new System.Drawing.Size(150, 40);
        tituloBuscar.Font = new Font("Impact", 14);
        this.Controls.Add(tituloBuscar);

        buscar = new System.Windows.Forms.TextBox();
        buscar.ForeColor = Color.Red;
        buscar.Location = new System.Drawing.Point(800, 160);
        buscar.Size = new System.Drawing.Size(100, 30);
        buscar.Font = new Font("Arial", 12);
        this.Controls.Add(buscar);

        MandarBusqueda = new System.Windows.Forms.Button();
        MandarBusqueda.Text = "Buscar";
        MandarBusqueda.ForeColor = Color.Blue;
        MandarBusqueda.Location = new System.Drawing.Point(800, 200);
        MandarBusqueda.Size = new System.Drawing.Size(100, 30);
        MandarBusqueda.Font = new Font("Impact", 14);
        this.Controls.Add(MandarBusqueda);
        MandarBusqueda.Click += BuscarObjeto;

        Buscado = new System.Windows.Forms.Label();
        Buscado.ForeColor = Color.Blue;
        Buscado.BackColor = Color.Bisque;
        Buscado.Location = new System.Drawing.Point(800, 270);
        Buscado.Size = new System.Drawing.Size(500, 50);
        Buscado.Font = new Font("Arial", 12);
        this.Controls.Add(Buscado);





        // Inicializa la conexión a la base de datos
        string connectionString = @"Data Source=DESKTOP-RHN630F\SQLEXPRESS02;Initial Catalog=refaccionaria;Integrated Security=True";
        sqlConnection = new SqlConnection(connectionString);



    }

    private void Form1_Load(object sender, EventArgs e)
    {
    // Carga los datos en el DataGridView al cargar el formulario
    CargarDatos();
    }

    private void CargarDatos()
    {
        try
        {
            // Abre la conexión
            sqlConnection.Open();

            // Crea el comando SQL para seleccionar todos los datos de la tabla "Camion"
            string query = "SELECT * FROM Camion";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asigna los datos al DataGridView
                dataGridView.DataSource = dataTable;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar datos: " + ex.Message);
        }
        finally
        {
            // Cierra la conexión
            sqlConnection.Close();
        }
    }

    private void EnviarDatos(object sender, EventArgs e)
    {
        try
        {
            // Abre la conexión
            sqlConnection.Open();

            // Crea el comando SQL para insertar datos en la tabla "Camion"
            string query = "INSERT INTO Camion (Nombre, Totalmacenaje, Placas, Marca) " +
                           "VALUES (@Nombre, @Totalmacenaje, @Placas, @Marca)";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                // Configura los parámetros del comando
                cmd.Parameters.AddWithValue("@Nombre", nombre.Text);
                cmd.Parameters.AddWithValue("@Totalmacenaje", Convert.ToDecimal(tonelajeDeAlmacenaje.Text));
                cmd.Parameters.AddWithValue("@Placas", placas.Text);
                cmd.Parameters.AddWithValue("@Marca", marca.Text);
                // Ejecuta el comando
                cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Datos enviados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                sqlConnection.Close();
            }

            CargarDatos();
        }

        public void BuscarObjeto(object sender, EventArgs e)
{
    try
    {
        // Abre la conexión
        sqlConnection.Open();

        // Verifica si el valor en el TextBox es un número entero válido
        if (int.TryParse(buscar.Text, out int idCamion))
        {
            // Crea el comando SQL para buscar un objeto por su ID
            string query = "SELECT * FROM Camion WHERE Idcamion = @Idcamion";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                // Configura el parámetro del comando con el valor del TextBox
                cmd.Parameters.AddWithValue("@Idcamion", idCamion);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Si se encuentran resultados, lee la primera fila
                    reader.Read();

                    // Actualiza el contenido del Label con los datos del objeto
                    Buscado.Text = $"IDcamion: {reader["Idcamion"]}, Nombre: {reader["Nombre"]}, Total Almacenaje: {reader["Totalmacenaje"]}, Placas: {reader["Placas"]}, Marca: {reader["Marca"]}";
                }
                else
                {
                    // Si no se encuentran resultados, muestra un mensaje indicando que no se encontró el objeto
                    Buscado.Text = "Objeto no encontrado";
                }
            }
        }
        else
        {
            MessageBox.Show("Por favor, ingrese un número entero válido para buscar.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al buscar objeto: " + ex.Message);
    }
    finally
    {
        // Cierra la conexión
        sqlConnection.Close();
    }
}


    #endregion
}
