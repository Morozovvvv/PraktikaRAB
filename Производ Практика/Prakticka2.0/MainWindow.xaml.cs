using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Prakticka2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int inter=10;
        Window1 win1 = new Window1();
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
        
            Grider.Visibility = Visibility.Hidden;
            TimerLBL.Content = "Блокировка авторизации сек:" + inter.ToString();
            if (inter == 0)
            {
                Grider.Visibility = Visibility.Visible;
                timer.Stop();
                CaptchaGenerator();
                inter = 10;
            }
            else
            {
               inter--;
            }
        }
 
        void CaptchaGenerator()
        {
            char[] chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".ToCharArray();
            string randomString = "";
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomString += chars[ran.Next(0, chars.Length)];
            }
            Capcha1.Text = randomString;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        Window1 menuWindow1 = new Window1();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text.Length > 0) // проверяем введён ли логин
            {
                if (PasswordBoxPassword.Password.Length > 0) // проверяем введён ли пароль
                {             // ищем в базе данных пользователя с такими данными
                    DataTable dt_user = mainWindow.Select("SELECT * FROM [dbo].[Login] WHERE [Login] = '" + TextBoxLogin.Text + "' AND [Password] = '" + PasswordBoxPassword.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует
                    {
                        DataTable dt_users =Select("SELECT * FROM [dbo].[Login]");
                        for (int i = 0; i < dt_users.Rows.Count; i++) // перебираем данные
                        {
                            if (TextBoxLogin.Text == dt_users.Rows[i][0].ToString())
                            {
                                menuWindow1.Photo.Source = new BitmapImage(new Uri(dt_users.Rows[i][2].ToString()));
                                menuWindow1.FIO.Content = dt_users.Rows[i][3].ToString();
                                menuWindow1.Doljnost.Content = dt_users.Rows[i][4].ToString();
                            }
                        }
                        mainWindow.Hide();
                       // Window1 menuWindow1 = new Window1();
                        menuWindow1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Пользователя не найден"); // выводим ошибку
                        timer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Введите пароль"); // выводим ошибку
                    timer.Start();
                }
            }
            else
            {
                MessageBox.Show("Введите логин"); // выводим ошибку
                timer.Start();
            }
            
        }
        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-BHACMI8;Trusted_Connection=Yes;DataBase=Login;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registraciya reg = new Registraciya();
            reg.Show();
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Batton_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = "";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }

            if (Capcha.Text != "")
            {
                Capcha.Text = null;
            }

            Capcha.Text = pwd;
        }

     
     

        private void Check_Click_1(object sender, RoutedEventArgs e)
        {
            if (Check.IsChecked == true)
            {
                Pass.Text = PasswordBoxPassword.Password;
                Pass.Visibility = Visibility.Visible;
                PasswordBoxPassword.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordBoxPassword.Password = Pass.Text;
                Pass.Visibility = Visibility.Hidden;
                PasswordBoxPassword.Visibility = Visibility.Visible;
            }
        }
    }
    }

