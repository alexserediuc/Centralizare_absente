using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizare_absente
{
	class StudentCollection
	{
		string fileName = "Students.json";
		string path;

		List<Student> students = new List<Student>();

        internal List<Student> Students { get => students; set => students = value; }

        public List<Student> GetStudents()
        {
			return students;
        }

		//In constructorul StudentCollection se realizeaza parcurgerea fisierului JSON
		//care contine toti studentii
		//cu scopul de a fi adaugati in lista students
		public StudentCollection()
		{
			path = Path.GetFullPath(fileName);

			if (!File.Exists(path))
			{
				File.Create(path).Close();
				
			}
			else
			{
				var streamReader = new StreamReader(path, new UTF8Encoding());
				var serializer = new JsonSerializer();

				using (var reader = new JsonTextReader(streamReader))
				{
					reader.CloseInput = false;
					reader.SupportMultipleContent = true;

					students = serializer.Deserialize<List<Student>>(reader);
					//students.Add(serializer.Deserialize<Student>(reader));

				}

				streamReader.Close();
			}

		}    

        //metoda addStudent va adauga studentul in lista students si totodata va scrie in fisierul JSON care contine studentii
        public void addStudent(Student student)
        {
			if(students != null)
				students.Add(student); // se adauga studentul in lista

				var jsonToWrite = JsonConvert.SerializeObject(students, Formatting.Indented);

				using (StreamWriter writer = new StreamWriter(path, append: false))
				{
					//writer.WriteLine(jsonToWrite);
					writer.WriteLine(jsonToWrite);

				}

        }

		public void addAbsenta(Absenta absenta, int indexStudent)
        {
			AbsentaCollection listaAbsente = students[indexStudent].Absente;

			listaAbsente.Absente.Add(absenta);

			rescriereFisier();
			//ineficient din punctul meu de vedere;
			//as rescrie fisierul doar la inchiderea completa a programului, cu scopul de a salva datele;
			//nu dupa fiecare inserare de abesnta;
			//dar nu mi-a iesit

		}

		private void rescriereFisier()
        {
			var toWrite = JsonConvert.SerializeObject(students, Formatting.Indented);

			using(StreamWriter writer = new StreamWriter(path))
            {
				writer.WriteLine(toWrite);
            }
        }

		public Student getStudentByID(string ID)
        {
			foreach(Student student in students)
            {
				if (student.getIdentificator() == ID)
					return student;
            }
			return null;
        }

		public override string ToString()
		{
			string stringStudenti = "";
			foreach(Student student in students)
            {
				stringStudenti += student.ToString() + "\n";
            }
			return stringStudenti;
        }
    }
}
