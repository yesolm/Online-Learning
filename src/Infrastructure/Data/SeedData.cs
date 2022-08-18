using Microsoft.EntityFrameworkCore;
using OL.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(
                new UserType { Id = 1, Name = "Instructor" },
                new UserType { Id = 2, Name = "Student" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Foundations: Data, Data, Everywhere",
                    Discription = "This is the first course in the Google Data Analytics Certificate. These courses will equip you with the skills you need to apply to introductory-level data analyst jobs. Organizations of all kinds need data analysts to help them improve their processes, identify opportunities and trends, launch new products, and make thoughtful decisions. In this course, you’ll be introduced to the world of data analytics through hands-on curriculum developed by Google. The material shared covers plenty of key data analytics topics, and it’s designed to give you an overview of what’s to come in the Google Data Analytics Certificate. Current Google data analysts will instruct and provide you with hands-on ways to ",
                    ImageGuid = "f1bc1590455c4a8e842056cc7c1da7c4"
                },
                new Course
                {
                    Id = 2,
                    Name = "Neural Networks and Deep Learning",
                    Discription = "In the first course of the Deep Learning Specialization, you will study the foundational concept of neural networks and deep learning. ",
                    ImageGuid = "d6356325839d40c8af2e680e57e6ee19"
                },
                new Course
                {
                    Id = 3,
                    Name = "Python Data Structures",
                    Discription = "This course will introduce the core data structures of the Python programming language. We will move past the basics of procedural programming and explore how we can use the Python built-in data structures such as lists, dictionaries, and tuples to perform increasingly complex data analysis. This course will cover Chapters 6-10 of the textbook “Python for Everybody”.  This course covers Python 3.",
                    ImageGuid = "78831b260329401fb80b3baf8ec21b08"
                },
                new Course
                {
                    Id = 4,
                    Name = "Excel Skills for Business: Essentials",
                    Discription = "In this first course of the specialization Excel Skills for Business, you will learn the essentials of Microsoft Excel. Within six weeks, you will be able to expertly navigate the Excel user interface, perform basic calculations with formulas and functions, professionally format spreadsheets, and create visualizations of data through charts and graphs.",
                    ImageGuid = "540cfc8106f8458da47c369aa424a4b1"
                },
                new Course
                {
                    Id = 5,
                    Name = "SQL for Data Science",
                    Discription = "As data collection has increased exponentially, so has the need for people skilled at using and interacting with data; to be able to think critically, and provide insights to make better decisions and optimize their businesses. This is a data scientist, “part mathematician, part computer scientist, and part trend spotter” (SAS Institute, Inc.). According to Glassdoor, being a data scientist is the best job in America; with a median base salary of $110,000 and thousands of job openings at a time. The skills necessary to be a good data scientist include being able to retrieve and work with data, and to do that you need to be well versed in SQL, the standard language for communicating with database systems.",
                    ImageGuid = "27c48582b6f64ae1a8e9d44bec11435a"
                });

        }
    }
}