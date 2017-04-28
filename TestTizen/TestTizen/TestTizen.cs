using System.Collections.Generic;
using Xamarin.Forms;

namespace TestTizen
{
    public class App : Application
    {
        
        public App()
        
        {
            Employee[] employeeArray = new Employee[3];

           

            employeeArray[0] = new Employee {FirstName="fattaneh" , LastName = "ameri"};

            employeeArray[1] = new Employee {FirstName = "farah", LastName = "mahabadian"};

            employeeArray[2] = new Employee {FirstName = "Reza", LastName = "amirkiani"};

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee{ FirstName = "mamd", LastName = "hasani" });

            employeeList.Add(new Employee{FirstName = "ebi" , LastName = "amiri"});


            // The root page of your application
            MainPage = new ContentPage
            {
              
                Content = new StackLayout
                
            {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"}
                        ,
                            new ListView
                            {
                                
                                ItemsSource = employeeArray
                        },new ListView
                        {
                            ItemsSource = employeeList
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
