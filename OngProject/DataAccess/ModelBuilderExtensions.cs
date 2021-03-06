using Microsoft.EntityFrameworkCore;
using OngProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.DataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void SeedOrganizations(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                Random vPhone = new Random();

                modelBuilder.Entity<Organizations>().HasData(
                    new Organizations
                    {
                        Id = i,
                        Name = "Organization" + i,
                        Image = "ImageOrganization" + i,
                        Address = "AddressOrganization" + i,
                        Phone = 999999999,
                        Email = "contact@organization" + i + ".com",
                        WelcomeText = "Wellcome Text...",
                        AboutUsText = "About Us Text...",
                        facebookUrl = "https://www.facebook.com/" + "organization" + i,
                        instagramUrl = "https://www.instagram.com/" + "organization" + i,
                        linkedinUrl = "https://www.linkedin.com/" + "organization" + i,
                        DateModified = DateTime.Now
                    });
            }
        }

        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Categories>().HasData(
                    new Categories 
                    {
                        Id = i,
                        Name = "Category" + i,
                        Description = "Category description " + i,
                        Image = " Image from category " + i,
                        DateModified = DateTime.Now
                    });
            }
        }

        public static void SeedActivities(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Activities>().HasData(
                    new Activities
                    {
                        Id = i,
                        Name = "Activity" + i,
                        Content = "Content from activity" + i,
                        Image = "Image from activity " + i,
                        DateModified = DateTime.Now
                    });
            }
        }

        public static void SeedNews(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<News>().HasData(
                    new News
                    {
                        Id = i,
                        Name = "News" + i,
                        Content = "Content from News" + i,
                        Image = "Image from News" + i,
                        CategoriesId = i,
                        DateModified = DateTime.Now
                    });
            }

        }

        public static void SeedComentaries(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Comentaries>().HasData(
                    new Comentaries
                    {
                        Id = i,
                        UserId = i,
                        Body = "Body from comentaries" + i,
                        NewsId = i,
                        DateModified = DateTime.Now
                    });
            }

        }

        public static void SeedMembers(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Members>().HasData(
                    new Members
                    {
                        Id = i,
                        name = "News" + i,
                        description = "Description from Member " + i,
                        image = "Image from Member" + i,
                        facebookUrl = "https://www.faceboook.com/Member"+i,
                        instagramUrl = "https://www.instagram.com/Member" + i,
                        lindedinUrl  = "https://www.linkedin.com/Member" + i,
                        DateModified = DateTime.Now
                    });
            }

        }


   

       
        public static void SeedSlides(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Slides>().HasData(
                    new Slides
                    {
                        image = "imagen for slide" + i,
                        text = "text for slide" + i,
                        orden = "" + i,
                        OrganizationsId = i,
                        Id =i

                    }); ; 
            }

        }
        public static void SeedTestimonials(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<testimonials>().HasData(
                    new testimonials
                    {
                        Id = i,
                        name = "testimoniasl" + i,
                        image = "Image from testimonials" + i,
                        content="Content from testimonials"+i,
                        DateModified = DateTime.Now,
                        
                    }); 
            }

        }

        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    Id = 1,
                    Description = "Rol Administrador",
                    Name = "Administrador",
                    DateModified = DateTime.Now
                },
                 new Roles
                 {
                     Id = 2,
                     Description = "Rol Comun",
                     Name = "Comun",
                     DateModified = DateTime.Now
                 });

        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            //se crearàn 3 usuarios respectivamente
            //El primero es Administrador
            //El resto comun

            int i = 1;
            int j = 2;
            int k = 3;
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = i,
                    FirstName = "User" + i,
                    Email = "email@user " + i,
                    LastName = "User" + i,
                    Password = "*****" + i,
                    Photo = "photo" + i,
                    RolesId = i,
                    DateModified = DateTime.Now
                },
                new Users
                {
                    Id = j,
                    FirstName = "User" + j,
                    Email = "email@user " + j,
                    LastName = "User" + j,
                    Password = "*****" + j,
                    Photo = "photo" + j,
                    RolesId = j,
                    DateModified = DateTime.Now
                },
                 new Users
                 {
                     Id = k,
                     FirstName = "User" + k,
                     Email = "email@user " + k,
                     LastName = "User" + k,
                     Password = "*****" + k,
                     Photo = "photo" + k,
                     RolesId = j,
                     DateModified = DateTime.Now
                 });
        }

        public static void SeedContacts(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Contacts>().HasData(
                    new Contacts
                    {
                        Id = i,
                        name = "name" + i,
                        phone = "phone" + i,
                        email = "contacts" + i+"@contacts.com",
                        message = "Content from contacts" + i,
                        DateModified = DateTime.Now,

                    });
            }

        }

    }
}
