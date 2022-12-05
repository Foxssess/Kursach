using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Kursach.DbContextDate
{
    public class DbContextData : DbContext
    {
        string connectionString;
        public DbContextData(string connection)
        {
            connectionString = connection;
        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                    new Patient { Id = 1, FirstName = "Антон", SecondName = "Романов", FatherName = "Романович", Address = "г.Казань, Короленко 39", BirthDay = new DateOnly(2004, 10, 30), Gender = "Мужской", Phone = "+79061111111", Passport = "3214 129531", Polis = "21413515", Snils = "11111111" },
                    new Patient { Id = 2, FirstName = "Даниль", SecondName = "Хафизов", FatherName = "Мансурович", Address = "г.Казань, Кремлёвская 17 ", BirthDay = new DateOnly(2001, 06, 15), Gender = "Мужской", Phone = "+79061234511", Passport = "1111 111111", Polis = "22222222", Snils = "22222222" },
                    new Patient { Id = 3, FirstName = "Сергей", SecondName = "Рагинов", FatherName = "Владимирович", Address = "г.Казань, Курчатова 35 ", BirthDay = new DateOnly(1990, 07, 27), Gender = "Мужской", Phone = "+79061234511", Passport = "2222 222222", Polis = "33333333", Snils = "33333333" },
                    new Patient { Id = 4, FirstName = "Тимур", SecondName = "Кергилов", FatherName = "Айдарович", Address = "г.Казань, Качалова 79 ", BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+79061234511", Passport = "3333 333333", Polis = "44444444", Snils = "44444444" },
                    new Patient { Id = 5, FirstName = "Светлана", SecondName = "Лазарева", FatherName = "Айдаровна", Address = "г.Казань, Танковая 1 ", BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+79061234511", Passport = "4444 444444", Polis = "55555555", Snils = "55555555" },
                    new Patient { Id = 6, FirstName = "Данила", SecondName = "Тихонов", FatherName = "Александрович", Address = "г.Казань, Фучика 28", BirthDay = new DateOnly(2000, 01, 05), Gender = "Мужской", Phone = "+790611567891", Passport = "5555 555555", Polis = "66666666", Snils = "66666666" },
                    new Patient { Id = 7, FirstName = "Вячеслав", SecondName = "Гасанов", FatherName = "Семёнович", Address = "г.Казань, Жириновского 35 ", BirthDay = new DateOnly(1989, 06, 27), Gender = "Мужской", Phone = "+79061542511", Passport = "1212 121212", Polis = "77777777", Snils = "77777777" },
                    new Patient { Id = 8, FirstName = "Юлия", SecondName = "Субботина", FatherName = "Павловна", Address = "г.Казань, Качалова 79 ", BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+79061234511", Passport = "3232 323232", Polis = "88888888", Snils = "88888888" },
                    new Patient { Id = 9, FirstName = "Ксения", SecondName = "Яшкина", FatherName = "Алексеевна", Address = "г.Казань, Бульваровна 1 ", BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+79068734511", Passport = "4242 242424", Polis = "99999999", Snils = "99999999" },
                    new Patient { Id = 10, FirstName = "Дарья", SecondName = "Мишина", FatherName = "Михайловна", Address = "г.Казань, Гордеева 28", BirthDay = new DateOnly(2000, 01, 05), Gender = "Женский", Phone = "+79125467891", Passport = "4545 454554", Polis = "10101012", Snils = "19191991" }
                    );

            
            
            modelBuilder.Entity<Doctor>().HasData(
              new Doctor { Id = 1, FirstNameDoctor = "Ирина", SecondNameDoctor = "Хафизова", FatherNameDoctor = "Олеговна", Adress = "г. Казань, ул. Победы 72", BirthDay = new DateOnly(1990, 06, 15), Experience = "5", Phone = "+7906123123", Post = "Ортодонт" , Diploma = "2312312", MilitaryTicket = "1212121", Passport = "1234 123234", Snils = "12321321"     },
              new Doctor { Id = 2, FirstNameDoctor = "Артур", SecondNameDoctor = "Хасанов", FatherNameDoctor = "Артёмович", Adress = "г. Казань, ул. Октябрьской революции 31", BirthDay = new DateOnly(1972, 07, 27), Experience = "20", Phone = "+7906126544", Post = "Стоматолог- терапевт",Diploma = "7777777", MilitaryTicket = "4545454", Passport = "9999 999999", Snils = "19191991"     },
              new Doctor { Id = 3, FirstNameDoctor = "Адель", SecondNameDoctor = "Минвалеев", FatherNameDoctor = "Ильгизарович", Adress = "г. Казань, ул. Степана Разина 25", BirthDay = new DateOnly(1980, 06, 19), Experience = "12", Phone = "+790612545", Post = "Стоматолог - хирург", Diploma = "8888888", MilitaryTicket = "6565665", Passport = "3333 191919", Snils = "29292929"     },
              new Doctor { Id = 4, FirstNameDoctor = "Дмитрий", SecondNameDoctor = "Папичев", FatherNameDoctor = "Витальевич", Adress = "г. Казань, ул. Тополиная 51", BirthDay = new DateOnly(1994, 01, 01), Experience = "1", Phone = "+7906656723", Post = "Ортодонт", Diploma = "9999999", MilitaryTicket = "7676767", Passport = "4444 292929", Snils = "39393939"     },
              new Doctor { Id = 5, FirstNameDoctor = "Кирилл", SecondNameDoctor = "Панков", FatherNameDoctor = "Олегович", Adress = "г. Казань, ул. Дзержинского 67", BirthDay = new DateOnly(1985, 02, 27), Experience = "6", Phone = "+7906125464", Post = "Стоматолог- терапевт",Diploma = "1010101", MilitaryTicket = "8787878", Passport = "5555 393939", Snils = "49049494"     },
              new Doctor { Id = 6, FirstNameDoctor = "Никита", SecondNameDoctor = "Андреев", FatherNameDoctor = "Игоревич", Adress = "г. Казань, ул. Пантелеева 25", BirthDay = new DateOnly(1980, 02, 19), Experience = "12", Phone = "+790698745", Post = "Стоматолог - хирург", Diploma = "1919191", MilitaryTicket = "9898989", Passport = "1234 494949", Snils = "59559595"     },
              new Doctor { Id = 7, FirstNameDoctor = "Владимир", SecondNameDoctor = "Дедов", FatherNameDoctor = "Владимирович", Adress = "г. Казань, ул. Кремлёвская 1", BirthDay = new DateOnly(1952, 10, 08), Experience = "40",  Phone = "+7912322228", Post = "Ортодонт", Diploma = "2121212", MilitaryTicket = "1013405", Passport = "4444 424224", Snils = "12312413"     },
              new Doctor { Id = 8, FirstNameDoctor = "Володимир", SecondNameDoctor = "Клоунов", FatherNameDoctor = "Александрович", Adress = "г. Казань, ул. Русская 21", BirthDay = new DateOnly(1968, 02, 24), Experience = "30",  Phone = "+79061678844", Post = "Стоматолог- терапевт", Diploma = "8678678", MilitaryTicket = "6536346", Passport = "5555 656564", Snils = "75474534"     },
              new Doctor { Id = 9, FirstNameDoctor = "Джонатан ", SecondNameDoctor = "Бидонов", FatherNameDoctor = "Джозефович", Adress = "г. Казань, ул. Победы 15", BirthDay = new DateOnly(1960, 06, 19), Experience = "35",  Phone = "+797567545", Post = "Стоматолог - хирург", Diploma = "4564564", MilitaryTicket = "2343243", Passport = "1234 756756", Snils = "97890978"     },
              new Doctor { Id = 10, FirstNameDoctor = "Юрий", SecondNameDoctor = "Дудков", FatherNameDoctor = "Сергеевич", Adress = "г. Казань, ул. Переобувочная 2", BirthDay = new DateOnly(1985, 03, 09), Experience = "7",  Phone = "+790689605", Post = "Стоматолог - хирург", Diploma = "7475231", MilitaryTicket = "7657563", Passport = "1234 756742", Snils = "76700567" }

              );
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, NamePost = "Ортодонт", RatePerHour = 875 },
                new Post { Id = 2, NamePost = "Стоматолог - хирург", RatePerHour = 732 },
                new Post { Id = 3, NamePost = "Стоматолог- терапевт", RatePerHour = 652 }

              );
            modelBuilder.Entity<Reception>().HasData(
               new Reception { Id = 1, Cost = "1000", Data = new DateOnly(2022, 01, 14), DoctorId = 1, NameService = "Консультация", Room = "Кабинет 1", Time = "17:20", PatientId = 1 },
               new Reception { Id = 2, Cost = "2500", Data = new DateOnly(2021, 06, 01), DoctorId = 2, NameService = "Чистка зубов", Room = "Кабинет 2", Time = "15:13", PatientId = 2 },
               new Reception { Id = 3, Cost = "10000", Data = new DateOnly(2022, 04, 19), DoctorId = 3, NameService = "Установка пломбы", Room = "Кабинет 3", Time = "07:30", PatientId = 3 },
               new Reception { Id = 4, Cost = "15000", Data = new DateOnly(2022, 03, 15), DoctorId = 4, NameService = "Установка брекетов", Room = "Кабинет 4", Time = "09:00", PatientId = 4 },
               new Reception { Id = 5, Cost = "2500", Data = new DateOnly(2019, 06, 13), DoctorId = 5,NameService = "Чистка зубов", Room = "Кабинет 5", Time = "12:13", PatientId = 5 },
               new Reception { Id = 6, Cost = "15000", Data = new DateOnly(2022, 02, 13), DoctorId = 6, NameService = "Установка брекетов", Room = "Кабинет 6", Time = "15:17", PatientId = 6 },
               new Reception { Id = 7, Cost = "10000", Data = new DateOnly(2021, 08, 19), DoctorId = 7,NameService = "Установка пломбы", Room = "Кабинет 7", Time = "18:45", PatientId = 7 },
               new Reception { Id = 8, Cost = "1000", Data = new DateOnly(2021, 03, 11), DoctorId =  8,NameService = "Консультация", Room = "Кабинет 8", Time = "20:15", PatientId = 8 },
               new Reception { Id = 9, Cost = "10000", Data = new DateOnly(2022, 07, 25), DoctorId = 9,NameService = "Установка пломбы", Room = "Кабинет 9", Time = "11:45", PatientId = 9 },
               new Reception { Id = 10, Cost = "15000", Data = new DateOnly(2020, 06, 15), DoctorId = 10,NameService = "Установка брекетов", Room = "Кабинет 10", Time = "13:27", PatientId = 10 }

                );

            modelBuilder.Entity<Services>().HasData(
                new Services { Id = 1, NameService = "Чистка зубов", Cost = 2500, IdPost = 3 },
                new Services { Id = 2, NameService = "Установка брекетов", Cost = 150000, IdPost = 1 },
                new Services { Id = 3, NameService = "Установка пломбы", Cost = 100000, IdPost = 2 }
 );

            modelBuilder.Entity<WorkTime>().HasData(
                new WorkTime { Id = 1, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 1, Data = new DateOnly(2022, 11, 28) },
                new WorkTime { Id = 2, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 1, Data = new DateOnly(2022,11,28) },
                new WorkTime { Id = 3, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 2, Data = new DateOnly(2022, 11, 28) },
                new WorkTime { Id = 4, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 3, Data = new DateOnly(2022, 11, 28) },
                new WorkTime { Id = 5, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 4, Data = new DateOnly(2022,11,28) },
                new WorkTime { Id = 6, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 5, Data = new DateOnly(2022,11,28) },
                new WorkTime { Id = 7, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 6, Data = new DateOnly(2022,11,28) },
                new WorkTime { Id = 8, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 7, Data = new DateOnly(2022,11, 28) },
                new WorkTime { Id = 9, BeginShift = "14:30", TypeShift = "Первая ", EndShift = "22:00", DoctorId = 8, Data = new DateOnly(2022,11,28)},
                new WorkTime { Id = 10, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 9, Data = new DateOnly(2022,11,28)},
                new WorkTime { Id = 11, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 10, Data = new DateOnly(2022,11,28)},
                new WorkTime { Id = 12, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 2, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 13, BeginShift = "07:00", TypeShift = "Вторая  ", EndShift = "14:30", DoctorId = 3, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 14, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 4, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 15, BeginShift = "07:00", TypeShift = "Вторая  ", EndShift = "14:30", DoctorId = 5, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 16, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 6, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 17, BeginShift = "07:00", TypeShift = "Вторая  ", EndShift = "14:30", DoctorId = 7, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 18, BeginShift = "07:00", TypeShift = "Вторая ", EndShift = "14:30", DoctorId = 8, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 19, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 9, Data = new DateOnly(2022,11,29) },
                new WorkTime { Id = 20, BeginShift = "07:00", TypeShift = "Вторая  ", EndShift = "14:30", DoctorId = 10, Data = new DateOnly(2022,11,29) }

               );
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, NameRoom = "Кабинет 1" },
                new Room { Id = 2, NameRoom = "Кабинет 2" },
                new Room { Id = 3, NameRoom = "Кабинет 3" },
                new Room { Id = 4, NameRoom = "Кабинет 4" },
                new Room { Id = 5, NameRoom = "Кабинет 5" },
                new Room { Id = 6, NameRoom = "Кабинет 6" },
                new Room { Id = 7, NameRoom = "Кабинет 7" },
                new Room { Id = 8, NameRoom = "Кабинет 8" },
                new Room { Id = 9, NameRoom = "Кабинет 9" },
                new Room { Id = 10, NameRoom = "Кабинет 10" }
                );




              }
    }
  };
