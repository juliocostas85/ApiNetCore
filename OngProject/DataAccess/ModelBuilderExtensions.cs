﻿using Microsoft.EntityFrameworkCore;
using OngProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.DataAccess
{
    public static class ModelBuilderExtensions
    {
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
                        CategoryId = i,
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
        public static void SeedTestimonials(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<testimonials>().HasData(
                    new testimonials
                    {
                        name = "testimoniasl" + i,
                        image = "Image from testimonials" + i,
                        content="Content from testimonials"+i,
                        deleteAt = DateTime.Now,
                        
                    }); 
            }

        }
    }
}
