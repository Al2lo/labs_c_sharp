using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba_9
{
    interface IRepositoty<T> where T:class
    {
        IEnumerable<T> GerAll();
        T Get(int id);
        void Insert();
        void Update();
        void Delete();
    }

    internal class UserRepositoriy
    {
        private static MainWindow window = (MainWindow)System.Windows.Application.Current.MainWindow;
        private UserContext db;
        
        public UserRepositoriy(UserContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.ToArray()[id]; 
        }

        public void Insert()
        {
            User user = new User();
            user.Id = Int32.Parse(window.Text_id.Text.ToString());
            user.Name = window.Text_Name.Text.ToString();
            user.Age = Int32.Parse(window.Text_Age.Text.ToString());
            db.Users.Add(user);
            db.SaveChanges();
            window.Container.ItemsSource = db.Users.ToList<User>();
        }   
        public void Update()
        {
            User u = (User)window.Container.SelectedItem;
            var user = db.Users.Single<User>(b => b.Id == u.Id);
            user.Name = window.Text_Name.Text.ToString();
            user.Age = Int32.Parse(window.Text_Age.Text.ToString());
            db.SaveChanges();
            window.Container.ItemsSource = db.Users.ToList<User>();
        }
        public void Delete()
        {
            db.Users.Remove((User)window.Container.SelectedItem);
            db.SaveChanges();
            window.Container.ItemsSource = db.Users.ToList<User>();
        }

        public void Search()
        {
            if (window.textSearchOrFilter.Text == "all")
            {
                window.Container.ItemsSource = db.Users.ToList<User>();
                return;
            }
            var users = db.Users.Where<User>(b => b.Name == window.textSearchOrFilter.Text);
            window.Container.ItemsSource = users.ToList<User>();
        }

        public void Filter()
        {
            IOrderedQueryable<User> users = null;
            if (window.textSearchOrFilter.Text == "id")
            {
                users = db.Users.OrderBy(p => p.Id);
            }
            else if (window.textSearchOrFilter.Text == "name")
            {
                users = db.Users.OrderBy(p => p.Name);
            }
            else if (window.textSearchOrFilter.Text == "age")
            {
                users = db.Users.OrderBy(p => p.Age);
            }
            else
            {
                MessageBox.Show("Not Correct Filter");
                return;
            }
            window.Container.ItemsSource = users.ToList<User>();
        }
    }
}
