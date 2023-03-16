using Microsoft.EntityFrameworkCore;
using PageBE.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.Helper
{
    public static class SeedingData
    {
        public static void SeedStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusStudenta>().HasData(
                    new StatusStudenta { statusId = 1, NazivStatusa = "Redovan" },
                    new StatusStudenta { statusId = 2, NazivStatusa = "Vanredan"}
                );
        }

        public static void SeedKurs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kurs>().HasData(
                    new Kurs { kursId = 1, NazivKursa = "Web Programiranje" },
                    new Kurs { kursId = 2, NazivKursa = "RWA"},
                    new Kurs { kursId = 3, NazivKursa = "ISMO"},
                    new Kurs { kursId = 4, NazivKursa = "IS"}
                );
        }

        public static void SeedStudenta(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studenti>().HasData(
                new Studenti { studentId = 1, brojIndexa = 1111, Ime = "Ime 1", Prezime = "Nakon Seeda", Godina = 3, statusId = 1 },
                new Studenti { studentId = 2, brojIndexa = 1221, Ime = "Ime 2", Prezime = "Nakon Seeda", Godina = 1, statusId = 2 },
                new Studenti { studentId = 3, brojIndexa = 13331, Ime = "Ime 3", Prezime = "Nakon Seeda", Godina = 2, statusId = 1 }
                );
        }

        public static void SeedKursStudenta(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KursStudenta>().HasData(
                new KursStudenta { kursStudentaId = 1, studentId = 3, kursId = 3 },
                new KursStudenta { kursStudentaId = 2, studentId = 1, kursId = 2 },
                new KursStudenta { kursStudentaId = 3, studentId = 2, kursId = 1 }
                );
        }
    }
}
