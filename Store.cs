
using System.Text.Json;

class Store {
    List<StorePerson> persons = new List<StorePerson>();

    //made the constructor to input the json file, add to the list of persons
         public Store() {
        using (StreamReader reader = new StreamReader("store.json")) {
            string json = reader.ReadToEnd();
            persons = JsonSerializer.Deserialize<List<StorePerson>>(json);
        }
    }

    //take as callback function
    public void Show(){
        foreach(var person in persons){
            Console.WriteLine(person);
        }
    }


    public void Show(int length){
        int i=1;
        foreach(var person in persons){
            if(person.Name.Length > length){
                Console.WriteLine($"{i} {person.ToString()}");
                i++;
        }
    }


    public void Show(string name){
        int i=1;
        foreach(var person in persons){
            if(person.Name == name){
                Console.WriteLine($"{i} {person.ToString()}");
                i++;
            }
        }
    }

    public void Show(double amount){
        int i=1;
        foreach(var person in persons){
            if(person.Salary > amount){
                Console.WriteLine($"{i} {person.ToString()}");
                i++;
            }
        }
    }

    }




    public void Save(){
        string json = JsonSerializer.Serialize(persons);
        using (StreamWriter writer = new StreamWriter("store.json")) {
            writer.Write(json);
        }

  
    }







}



