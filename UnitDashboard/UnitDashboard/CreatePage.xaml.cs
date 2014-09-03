using System;
using System.Windows.Controls;
using UnitDashboard.App_Data;
using System.Data.Objects;

namespace UnitDashboard
{
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            //string connectionString = "data source=АЛЕКСЕЙ-ПК;initial catalog=myDataBase;persist security info=True;user id=human;password=human;MultipleActiveResultSets=True;";
            //SqlConnection connDBPageOptions = new SqlConnection(connectionString);

            //try
            //{
            //    conn.Open();
            //}
            //catch (SqlException se)
            //{
            //    Console.WriteLine("Ошибка подключения:{0}", se.Message);
            //}
            //Console.WriteLine("Соедение успешно произведено");
            
            using( DBPageOptionsEntities dbPageOptions = new DBPageOptionsEntities() )
            {
                ObjectParameter lenParameter = new ObjectParameter("Len", typeof(int));
                dbPageOptions.Len(lenParameter);
                int len = Convert.ToInt32(lenParameter.Value);

                if (len != 0)
                {
                    dbPageOptions.Delete();
                }
                
                dbPageOptions.Insert(TBox_0.Text, "Text");
                dbPageOptions.Insert(TBox_1.Text, "Request");
                dbPageOptions.Insert(CBox_0.SelectedItem.ToString(), "Service");
                dbPageOptions.Insert(CBox_1.SelectedItem.ToString(), "Service");

                dbPageOptions.SaveChanges();
            }
        }
    }
}
