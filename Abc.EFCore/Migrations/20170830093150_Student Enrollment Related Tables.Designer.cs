﻿// <auto-generated />
using Abc.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Abc.EFCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170830093150_Student Enrollment Related Tables")]
    partial class StudentEnrollmentRelatedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abc.EFCore.Data.Entity.AcademicYear", b =>
                {
                    b.Property<int>("AcademicYearId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Year");

                    b.Property<string>("YearCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("AcademicYearId");

                    b.ToTable("AcademicYear");
                });

            modelBuilder.Entity("Abc.EFCore.Data.Entity.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(1024);

                    b.Property<string>("CollegName")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("CollegeCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CollegeId");

                    b.ToTable("College");
                });

            modelBuilder.Entity("Abc.EFCore.Data.Entity.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Abc.EFCore.Data.Entity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Abc.EFCore.Data.Entity.StudentEnrollment", b =>
                {
                    b.Property<int>("StudentEnrollmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcademicYearId");

                    b.Property<int>("CollegeId");

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("EnrolledDate");

                    b.Property<int>("StudentId");

                    b.HasKey("StudentEnrollmentId");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("CollegeId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentEnrollment");
                });

            modelBuilder.Entity("Abc.EFCore.Data.Entity.StudentEnrollment", b =>
                {
                    b.HasOne("Abc.EFCore.Data.Entity.AcademicYear", "AcademicYear")
                        .WithMany("StudentEnrollments")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Abc.EFCore.Data.Entity.College", "College")
                        .WithMany()
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Abc.EFCore.Data.Entity.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Abc.EFCore.Data.Entity.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
