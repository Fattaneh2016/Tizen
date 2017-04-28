using System.Collections.Generic;
using Xamarin.Forms;

namespace TestTizen
{
    public class App : Application
    {
        
        public App()
        
        {

            //create listview
            Employee[] employeeArray = new Employee[3];

            employeeArray[0] = new Employee {FirstName="fattaneh" , LastName = "ameri"};

            employeeArray[1] = new Employee {FirstName = "farah", LastName = "mahabadian"};

            employeeArray[2] = new Employee {FirstName = "Reza", LastName = "amirkiani"};

            //create list

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee{ FirstName = "mamd", LastName = "hasani" });

            employeeList.Add(new Employee{FirstName = "ebi" , LastName = "amiri"});

            //create dictionary

            var employeeDictionary =new Dictionary<int, Employee>();

            employeeDictionary.Add(101 , new Employee
            {
                Id=101,
                FirstName = "ali",
                LastName = "Dashti"
            });
            employeeDictionary.Add(102,new Employee
            {
                Id=102,
                FirstName = "Mohsen",
                LastName = "Fazeli"
            });

            // The root page of your application
            MainPage = new ContentPage
            {
              
                Content = new StackLayout
                
            {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Listview - list - Dictionary"}
                        ,
                            new ListView
                            {
                                
                                ItemsSource = employeeArray
                        },new ListView
                        {
                            ItemsSource = employeeList
                        },new Label
                        {
                           Text=employeeDictionary[101].ToString()

                        }
                        ,new Label
                        {
                            Text=employeeDictionary[102].ToString()

                        }

                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
