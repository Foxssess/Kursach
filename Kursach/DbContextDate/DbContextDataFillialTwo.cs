using Kursach.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.DbContextDate
{
    public class DbContextDataFillialTwo : DbContext
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
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MainOfficeFillialTwo;Username=postgres;Password=Microla412");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Patient>().HasData(
                        new Patient { Id = 1, FirstName = "Станислав", SecondName = "Рюрик", FatherName = "Романович", Address = "г.Казань, Короленко 39",  BirthDay = new DateOnly(2004, 10, 30), Gender = "Мужской", Phone = "+73234111111", Passport = "3999 129531", Polis = "24834343", Snils = "11991111" },
                        new Patient { Id = 2, FirstName = "Иван", SecondName = "Грозный", FatherName = "Иванович", Address = "г.Казань, Кремлёвская 17 ",  BirthDay = new DateOnly(2001, 06, 15), Gender = "Мужской", Phone = "+75466234511", Passport = "1909 111111", Polis = "22876876", Snils = "22992222" },
                        new Patient { Id = 3, FirstName = "Борис", SecondName = "Годунов", FatherName = "Владимирович", Address = "г.Казань, Курчатова 35 ",  BirthDay = new DateOnly(1990, 07, 27), Gender = "Мужской", Phone = "+79323534511", Passport = "2989 222222", Polis = "33376757", Snils = "33993333" },
                        new Patient { Id = 4, FirstName = "Наполеон", SecondName = "Бонапартович", FatherName = "Айдарович", Address = "г.Казань, Качалова 79 ",  BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+7323123451", Passport = "3989 333333", Polis = "44448785", Snils = "44994444" },
                        new Patient { Id = 5, FirstName = "Кристина", SecondName = "Бочкова", FatherName = "Айдаровна", Address = "г.Казань, Танковая 1 ",  BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+790656534511", Passport = "4989 444444", Polis = "55555765", Snils = "55995555" },
                        new Patient { Id = 6, FirstName = "Пальмиро", SecondName = "Тольятти", FatherName = "Александрович", Address = "г.Казань, Фучика 28",  BirthDay = new DateOnly(2000, 01, 05), Gender = "Мужской", Phone = "+79054557891", Passport = "5989 555555", Polis = "66666654", Snils = "66996666" },
                        new Patient { Id = 7, FirstName = "Федот", SecondName = "Якоревич", FatherName = "Семёнович", Address = "г.Казань, Жириновского 35 ",  BirthDay = new DateOnly(1989, 06, 27), Gender = "Мужской", Phone = "+79061905611", Passport = "1989 121212", Polis = "77777969", Snils = "77997777" },
                        new Patient { Id = 8, FirstName = "Александра", SecondName = "Хорькова", FatherName = "Павловна", Address = "г.Казань, Качалова 79 ",  BirthDay = new DateOnly(1970, 04, 01), Gender = "Мужской", Phone = "+79066578911", Passport = "3989 323232", Polis = "88888931", Snils = "88998888" },
                        new Patient { Id = 9, FirstName = "Елена", SecondName = "Безрукова", FatherName = "Алексеевна", Address = "г.Казань, Бульваровна 1 ",  BirthDay = new DateOnly(1996, 09, 16), Gender = "Женский", Phone = "+79067657321", Passport = "4898 242424", Polis = "99999931", Snils = "99889999" },
                        new Patient { Id = 10, FirstName = "Алёна", SecondName = "Дубровина", FatherName = "Михайловна", Address = "г.Казань, Гордеева 28",  BirthDay = new DateOnly(2000, 01, 05), Gender = "Женский", Phone = "+791255435491", Passport = "4994 454554", Polis = "10101912", Snils = "19891991" }
                        );

                 modelBuilder.Entity<Doctor>().HasData(
                  new Doctor { Id = 1, FirstNameDoctor = "Федосия", SecondNameDoctor = "Пальчикова", FatherNameDoctor = "Олеговна", Adress = "г. Казань, ул. Победы 72", BirthDay = new DateOnly(1990, 06, 15), Experience = "5", Phone = "+7906123123", Post = "Ортодонт" },
                  new Doctor { Id = 2, FirstNameDoctor = "Афанасий", SecondNameDoctor = "Мизинцев", FatherNameDoctor = "Артёмович", Adress = "г. Казань, ул. Октябрьской революции 31", BirthDay = new DateOnly(1972, 07, 27), Experience = "20", Phone = "+7906126544", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 3, FirstNameDoctor = "Мирослав", SecondNameDoctor = "Добролюбов", FatherNameDoctor = "Ильгизарович", Adress = "г. Казань, ул. Степана Разина 25", BirthDay = new DateOnly(1980, 06, 19), Experience = "12", Phone = "+790612545", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 4, FirstNameDoctor = "Алексей", SecondNameDoctor = "Попович", FatherNameDoctor = "Витальевич", Adress = "г. Казань, ул. Тополиная 51", BirthDay = new DateOnly(1994, 01, 01), Experience = "1", Phone = "+7906656723", Post = "Ортодонт" },
                  new Doctor { Id = 5, FirstNameDoctor = "Илья", SecondNameDoctor = "Муромец", FatherNameDoctor = "Олегович", Adress = "г. Казань, ул. Дзержинского 67", BirthDay = new DateOnly(1985, 02, 27), Experience = "6", Phone = "+7906125464", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 6, FirstNameDoctor = "Добрыня", SecondNameDoctor = "Ливанов", FatherNameDoctor = "Игоревич", Adress = "г. Казань, ул. Пантелеева 25", BirthDay = new DateOnly(1982, 02, 19), Experience = "9", Phone = "+790698745", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 7, FirstNameDoctor = "Роман", SecondNameDoctor = "Давыдов", FatherNameDoctor = "Владимирович", Adress = "г. Казань, ул. Кремлёвская 1", BirthDay = new DateOnly(1962, 10, 08), Experience = "30", Phone = "+7912322228", Post = "Ортодонт" },
                  new Doctor { Id = 8, FirstNameDoctor = "Тимур", SecondNameDoctor = "Клоунов", FatherNameDoctor = "Александрович", Adress = "г. Казань, ул. Русская 21", BirthDay = new DateOnly(1972, 02, 24), Experience = "20", Phone = "+79061678844", Post = "Стоматолог- терапевт" },
                  new Doctor { Id = 9, FirstNameDoctor = "Джонатан ", SecondNameDoctor = "Джостар", FatherNameDoctor = "Джозефович", Adress = "г. Казань, ул. Победы 15", BirthDay = new DateOnly(1985, 06, 19), Experience = "7", Phone = "+797567545", Post = "Стоматолог - хирург" },
                  new Doctor { Id = 10, FirstNameDoctor = "Иуда", SecondNameDoctor = "Балевич", FatherNameDoctor = "Сергеевич", Adress = "г. Казань, ул. Переобувочная 2", BirthDay = new DateOnly(1960, 03, 09), Experience = "34", Phone = "+790689605", Post = "Стоматолог - хирург" }

                  );
                modelBuilder.Entity<Post>().HasData(
                    new Post { Id = 1, NamePost = "Ортодонт", RatePerHour = 875 },
                    new Post { Id = 2, NamePost = "Стоматолог - хирург", RatePerHour = 732 },
                    new Post { Id = 3, NamePost = "Стоматолог- терапевт", RatePerHour = 652 }

                  );
                modelBuilder.Entity<Reception>().HasData(
                   new Reception { Id = 1, Cost = "1000", Data = new DateOnly(2020, 01, 14), Doctor = "Пальчикова", Patient= "Рюрик", NameService = "Консультация", Room = "Кабинет 1", Time = "17:20" },
                   new Reception { Id = 2, Cost = "2500", Data = new DateOnly(2020, 06, 01), Doctor = "Мизинцев", Patient= "Грозный", NameService = "Чистка зубов", Room = "Кабинет 2", Time = "15:13" },
                   new Reception { Id = 3, Cost = "10000", Data = new DateOnly(2019, 04, 19), Doctor = "Добролюбов",Patient = "Годунов", NameService = "Установка пломбы", Room = "Кабинет 3", Time = "07:30" },
                   new Reception { Id = 4, Cost = "15000", Data = new DateOnly(2019, 03, 15), Doctor = "Попович", Patient = "Бонапартович", NameService = "Установка брекетов", Room = "Кабинет 4", Time = "09:00" },
                   new Reception { Id = 5, Cost = "2500", Data = new DateOnly(2022, 06, 13), Doctor = "Муромец" ,Patient = "Бочкова", NameService = "Чистка зубов", Room = "Кабинет 5", Time = "12:13" },
                   new Reception { Id = 6, Cost = "15000", Data = new DateOnly(2019, 02, 13), Doctor = "Ливанов", Patient = "Тольятти", NameService = "Установка брекетов", Room = "Кабинет 6", Time = "15:17" },
                   new Reception { Id = 7, Cost = "10000", Data = new DateOnly(2022, 08, 19), Doctor = "Давыдов", Patient = "Якоревич", NameService = "Установка пломбы", Room = "Кабинет 7", Time = "18:45" },
                   new Reception { Id = 8, Cost = "1000", Data = new DateOnly(2019, 03, 11), Doctor = "Клоунов", Patient= "Хорькова", NameService = "Консультация", Room = "Кабинет 8", Time = "20:15" },
                   new Reception { Id = 9, Cost = "10000", Data = new DateOnly(2018, 07, 25), Doctor = "Джостар", Patient = "Безрукова", NameService = "Установка пломбы", Room = "Кабинет 9", Time = "11:45" },
                   new Reception { Id = 10, Cost = "15000", Data = new DateOnly(2016, 06, 15), Doctor = "Балевич", Patient = "Дубровина", NameService = "Установка брекетов", Room = "Кабинет 10", Time = "13:27" }

                    );

                modelBuilder.Entity<Services>().HasData(
                    new Services { Id = 1, NameService = "Чистка зубов", Cost = 2500, IdPost = 3 },
                    new Services { Id = 2, NameService = "Установка брекетов", Cost = 150000, IdPost = 1 },
                    new Services { Id = 3, NameService = "Установка пломбы", Cost = 100000, IdPost = 2 }
                    );


                modelBuilder.Entity<WorkTime>().HasData(
                    new WorkTime { Id = 1, BeginShift = "07:00", TypeShift = "Первая",  EndShift = "14:30", DoctorId = 1, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 2, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 1 , Data = new DateOnly(2022,11,29) },
                    new WorkTime { Id = 3, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 2, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 4, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 3, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 5, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 4, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 6, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 5, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 7, BeginShift = "14:30", TypeShift = "Первая",  EndShift = "22:00", DoctorId = 6, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 8, BeginShift = "14:30", TypeShift = "Вторая  ", EndShift = "22:00", DoctorId = 7, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 9, BeginShift = "14:30", TypeShift = "Первая ", EndShift = "22:00", DoctorId = 8, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 10, BeginShift = "14:30", TypeShift = "Первая", EndShift = "22:00", DoctorId = 9, Data = new DateOnly(2022, 11, 28) },
                    new WorkTime { Id = 11, BeginShift = "14:30", TypeShift = "Вторая " , EndShift = "22:00", DoctorId = 10, Data = new DateOnly(2022, 11, 28)},
                    new WorkTime { Id = 12, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 2, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 13, BeginShift = "07:00", TypeShift = "Вторая " , EndShift = "14:30", DoctorId = 3, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 14, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 4, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 15, BeginShift = "07:00", TypeShift = "Вторая " , EndShift = "14:30", DoctorId = 5, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 16, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 6, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 17, BeginShift = "07:00", TypeShift = "Вторая " , EndShift = "14:30", DoctorId = 7, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 18, BeginShift = "07:00", TypeShift = "Вторая ", EndShift = "14:30", DoctorId = 8, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 19, BeginShift = "07:00", TypeShift = "Первая", EndShift = "14:30", DoctorId = 9, Data = new DateOnly(2022, 11, 29) },
                    new WorkTime { Id = 20, BeginShift = "07:00", TypeShift = "Вторая", EndShift = "14:30", DoctorId = 10, Data = new DateOnly(2022, 11, 29) }

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

