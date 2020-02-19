using _20GRPEDC01BNT201__TP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20GRPEDC01BNT201__TP3.Repositories
{
    public class BirthdayRepository
    {
        public static List<BirthdayModel> Birthdays { get; set; }
            = new List<BirthdayModel>
            {
                new BirthdayModel
                {
                    Id = 1,
                    Nome = "Rodrigo",
                    Sobrenome = "Araujo",
                    Data = new DateTime(1986, 6, 11)
                }
            };
        public List<BirthdayModel> GetAll()
        {
            return Birthdays;
        }

        public BirthdayModel GetById(int id)
        {
            var birthday = Birthdays.FirstOrDefault(x => x.Id == id);
            return birthday;
        }

        public void Add(BirthdayModel createBirthdayModel)
        {
            Birthdays.Add(createBirthdayModel);
        }
        public void Update(BirthdayModel editBirthdayModel)
        {
            var oldBirthDayModel = GetById(editBirthdayModel.Id);
            oldBirthDayModel.Nome = editBirthdayModel.Nome;
        }
        public void Remove(int id)
        {
            var birthdayDelete = GetById(id);
            Birthdays.Remove(birthdayDelete);
        }
    }
}
