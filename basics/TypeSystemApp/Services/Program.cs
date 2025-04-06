using TypeSystemApp.Domain;

namespace TypeSystemApp.Services{
    class GreetingService{
        public string GetGreeting(Person p){
            return "Hello, " + p.Name + "! You are " + p.Age + " years old";
        }
    }
}
