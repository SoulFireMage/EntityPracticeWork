using System.Windows;
using System.Windows.Data;
using System.Data.Entity;
using EntityPracticeWork.Models;
using System.Collections.ObjectModel;

namespace EntityPracticeWork
    {
 
    public partial class MainWindow : Window
        {
        public UserDataEntities dbcontext = new UserDataEntities();
        static UserDataEntities dbStaticContext = new UserDataEntities();
        public ObservableCollection<person> persons = dbStaticContext.people.Local;
        public MainWindow()
            {
                InitializeComponent();
                CollectionViewSource PersonListViewSource = (CollectionViewSource)FindResource("PersonListViewSource");
                dbStaticContext.people.Load();
                persons.CollectionChanged += persons_CollectionChanged;
                PersonListViewSource.Source =persons;
          
            }
        private static void persons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
            dbStaticContext.SaveChanges();
            }
        }
    }
