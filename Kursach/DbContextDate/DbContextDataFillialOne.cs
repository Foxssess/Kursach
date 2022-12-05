using Kursach.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.DbContextDate
{
    public class DbContextDataFillialOne : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MainOfficeFillialOne;Username=postgres;Password=Microla412");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Patient>().HasData(
                        new Patient { Id = 1, FirstName = "Семён", SecondName = "Гордеев", FatherName = "Ильназович", Address = "г.Казань, Короленко 39",  BirthDay = new DateOnly(2004, 10, 30), Gender = "Мужской", Phone = "+79061111111", Passport = "9876 129531", Polis = "25646565", Snils = "1111111111" },
                        new Patient { Id = 2, FirstName = "Ильназ", SecondName = "Напальчиков", FatherName = "Мансурович", Address = "г.Казань, Кремлёвская 17 ",  BirthDay = new DateOnly(2001, 06, 15), Gender = "Мужской", Phone = "+79061234511", Passport = "6786 111111", Polis = "20989809", Snils = "1222222222" },
                        new Patient { Id = 3, FirstName = "Фёдор", SecondName = "Емельяненко", FatherName = "Владимирович", Address = "г.Казань, Курчатова 35 ",  BirthDay = new DateOnly(1990, 07, 27), Gender = "Мужской", Phone = "+79061234511",  Passport = "5466 222222", Polis = "39870987", Snils = "1333333333" },
                        new Patient { Id = 4, FirstName = "Тимур", SecondName = "Напалмов", FatherName = "Айдарович", Address = "г.Казань, Качалова 79 ",  BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+79061234511",    Passport = "7685 333333", Polis = "40980890", Snils = "1444444444" },
                        new Patient { Id = 5, FirstName = "Валентина", SecondName = "Фёдорова", FatherName = "Айдаровна", Address = "г.Казань, Танковая 1 ",  BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+79061234511",  Passport = "3456 444444", Polis = "59789879", Snils = "1555555555" },
                        new Patient { Id = 6, FirstName = "Манучехр", SecondName = "Боротов", FatherName = "Александрович", Address = "г.Казань, Фучика 28",  BirthDay = new DateOnly(2000, 01, 05), Gender = "Мужской", Phone = "+790611567891", Passport = "8769 555555", Polis = "68769789", Snils = "1666666666" },
                        new Patient { Id = 7, FirstName = "Георгий", SecondName = "Собакевич", FatherName = "Семёнович", Address = "г.Казань, Жириновского 35 ",  BirthDay = new DateOnly(1989, 06, 27), Gender = "Мужской", Phone = "+79061542511", Passport = "0890 121212", Polis = "79879879", Snils = "1777777777" },
                        new Patient { Id = 8, FirstName = "Варвара", SecondName = "Тышкун", FatherName = "Павловна", Address = "г.Казань, Качалова 79 ",  BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+79061234511",  Passport = "9493 323232", Polis = "80980978", Snils = "1888888888" },
                        new Patient { Id = 9, FirstName = "Ксения", SecondName = "Хмелёва", FatherName = "Алексеевна", Address = "г.Казань, Бульваровна 1 ",  BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+79068734511", Passport = "9199 242424", Polis = "98768767", Snils = "1999999999" },
                        new Patient { Id = 10, FirstName = "Дарья", SecondName = "Смирнова", FatherName = "Семёновна", Address = "г.Казань, Гордеева 28",  BirthDay = new DateOnly(2000, 01, 05), Gender = "Женский", Phone = "+79125467891",  Passport = "1999 454554", Polis = "10786877", Snils = "19649569965" }
                        );


               
                modelBuilder.Entity<Doctor>().HasData(
                  new Doctor { Id = 1, FirstNameDoctor = "Валентина", SecondNameDoctor = "Шалеева", FatherNameDoctor = "Олеговна", Adress = "г. Казань, ул. Победы 72", BirthDay = new DateOnly(1990, 06, 15), Experience = "5",  Phone = "+7906123123", Post = "Ортодонт" },
                  new Doctor { Id = 2, FirstNameDoctor = "Агат", SecondNameDoctor = "Сволов", FatherNameDoctor = "Артёмович", Adress = "г. Казань, ул. Октябрьской революции 31", BirthDay = new DateOnly(1972, 07, 27), Experience = "20" ,Phone = "+7906126544", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 3, FirstNameDoctor = "Нарцисс", SecondNameDoctor = "Леваков", FatherNameDoctor = "Ильгизарович", Adress = "г. Казань, ул. Степана Разина 25", BirthDay = new DateOnly(1980, 06, 19), Experience = "12", Phone = "+790612545", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 4, FirstNameDoctor = "Евгений", SecondNameDoctor = "Уколов", FatherNameDoctor = "Витальевич", Adress = "г. Казань, ул. Тополиная 51", BirthDay = new DateOnly(1994, 01, 01), Experience = "1", Phone = "+7906656723", Post = "Ортодонт" },
                  new Doctor { Id = 5, FirstNameDoctor = "Кирилл", SecondNameDoctor = "Стволеев", FatherNameDoctor = "Кириллов", Adress = "г. Казань, ул. Дзержинского 67", BirthDay = new DateOnly(1985, 02, 27), Experience = "6", Phone = "+7906125464", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 6, FirstNameDoctor = "Александр", SecondNameDoctor = "Ананьев", FatherNameDoctor = "Игоревич", Adress = "г. Казань, ул. Пантелеева 25", BirthDay = new DateOnly(1980, 02, 19), Experience = "12", Phone = "+790698745", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 7, FirstNameDoctor = "Константин", SecondNameDoctor = "Щавелев", FatherNameDoctor = "Владимирович", Adress = "г. Казань, ул. Кремлёвская 1", BirthDay = new DateOnly(1952, 10, 08), Experience = "40", Phone = "+7912322228", Post = "Ортодонт" },
                  new Doctor { Id = 8, FirstNameDoctor = "Михаил", SecondNameDoctor = "Качков", FatherNameDoctor = "Александрович", Adress = "г. Казань, ул. Русская 21", BirthDay = new DateOnly(1968, 02, 24), Experience = "30", Phone = "+79061678844", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 9, FirstNameDoctor = "Дио ", SecondNameDoctor = "Джостар", FatherNameDoctor = "Джонатович", Adress = "г. Казань, ул. Победы 15", BirthDay = new DateOnly(1960, 06, 19), Experience = "35", Phone = "+797567545", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 10, FirstNameDoctor = "Павел", SecondNameDoctor = "Правоков", FatherNameDoctor = "Сергеевич", Adress = "г. Казань, ул. Переобувочная 2", BirthDay = new DateOnly(1985, 03, 09), Experience = "7", Phone = "+790689605", Post = "Стоматолог - хирург" }

                  );
                modelBuilder.Entity<Post>().HasData(
                    new Post { Id = 1, NamePost = "Ортодонт", RatePerHour = 875 },
                    new Post { Id = 2, NamePost = "Стоматолог - хирург", RatePerHour = 732 },
                    new Post { Id = 3, NamePost = "Стоматолог- терапевт", RatePerHour = 652 }

                  );
                modelBuilder.Entity<Reception>().HasData(
                   new Reception { Id = 1, Cost = "1000", Data = new DateOnly(2021, 01, 14), DoctorId = 1, PatientId = 1, NameService = "Консультация", Room = "Кабинет 1", Time = "17:20" },
                   new Reception { Id = 2, Cost = "2500", Data = new DateOnly(2022, 06, 01), DoctorId = 2, PatientId = 2, NameService = "Чистка зубов", Room = "Кабинет 2", Time = "15:13" },
                   new Reception { Id = 3, Cost = "10000", Data = new DateOnly(2021, 04, 19), DoctorId = 3, PatientId = 3, NameService = "Установка пломбы", Room = "Кабинет 3", Time = "07:30" },
                   new Reception { Id = 4, Cost = "15000", Data = new DateOnly(2021, 03, 15), DoctorId = 4, PatientId = 4, NameService = "Установка брекетов", Room = "Кабинет 4", Time = "09:00" },
                   new Reception { Id = 5, Cost = "2500", Data = new DateOnly(2018, 06, 13), DoctorId = 5, PatientId = 5, NameService = "Чистка зубов", Room = "Кабинет 5", Time = "12:13" },
                   new Reception { Id = 6, Cost = "15000", Data = new DateOnly(2021, 02, 13), DoctorId = 6, PatientId = 6, NameService = "Установка брекетов", Room = "Кабинет 6", Time = "15:17" },
                   new Reception { Id = 7, Cost = "10000", Data = new DateOnly(2022, 08, 19), DoctorId = 7, PatientId = 7, NameService = "Установка пломбы", Room = "Кабинет 7", Time = "18:45" },
                   new Reception { Id = 8, Cost = "1000", Data = new DateOnly(2022, 03, 11), DoctorId = 8, PatientId = 8, NameService = "Консультация", Room = "Кабинет 8", Time = "20:15" },
                   new Reception { Id = 9, Cost = "10000", Data = new DateOnly(2021, 07, 25), DoctorId = 9, PatientId = 9, NameService = "Установка пломбы", Room = "Кабинет 9", Time = "11:45" },
                   new Reception { Id = 10, Cost = "15000", Data = new DateOnly(2022, 06, 15), DoctorId = 10, PatientId = 10, NameService = "Установка брекетов", Room = "Кабинет 10", Time = "13:27" }

                    );
              
                modelBuilder.Entity<Services>().HasData(  
                     new Services { Id = 1, NameService = "Чистка зубов", Cost = 2500, IdPost = 3 },  
                     new Services { Id = 2, NameService =  "Установка брекетов", Cost = 150000, IdPost = 1 },  
                     new Services { Id = 3, NameService = " Установка пломбы", Cost = 100000, IdPost =  2 }  
                    );


            modelBuilder.Entity<WorkTime>().HasData(
            new WorkTime { Id = 1, BeginShift = "07:00", TypeShift = "Первая",  EndShift = "14:30", DoctorId = 1, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 2, BeginShift = "14:30", TypeShift = "Вторая", EndShift = "22:00", DoctorId = 1, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 3, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 2, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 4, BeginShift = "14:30", TypeShift = "Вторая", EndShift = "22:00", DoctorId = 3, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 5, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 4, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 6, BeginShift = "14:30", TypeShift = "Вторая", EndShift = "22:00", DoctorId = 5, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 7, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 6, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 8, BeginShift = "14:30", TypeShift = "Вторая", EndShift = "22:00", DoctorId = 7, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 9, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 8, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 10, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 9, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 11, BeginShift = "14:30", TypeShift = "Вторая", EndShift = "22:00", DoctorId = 10, Data = new DateOnly(2022, 11, 28) },
            new WorkTime { Id = 12, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 2, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 13, BeginShift = "07:00", TypeShift = "Вторая" , EndShift = "14:30", DoctorId = 3, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 14, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 4, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 15, BeginShift = "07:00", TypeShift = "Вторая" , EndShift = "14:30", DoctorId = 5, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 16, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 6, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 17, BeginShift = "07:00", TypeShift = "Вторая" , EndShift = "14:30", DoctorId = 7, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 18, BeginShift = "07:00", TypeShift = "Вторая", EndShift = "14:30", DoctorId = 8, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 19, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 9, Data = new DateOnly(2022, 11, 29) },
            new WorkTime { Id = 20, BeginShift = "07:00", TypeShift = "Вторая"  , EndShift = "14:30", DoctorId = 10, Data = new DateOnly(2022, 11, 29) }

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
    }

