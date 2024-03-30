﻿// <auto-generated />
using System;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobLeet.WebApi.Migrations
{
    [DbContext(typeof(BaseDBContext))]
    partial class BaseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.RegisterUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RegisterUsers");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int>("RoleName")
                        .HasColumnType("int")
                        .HasColumnName("role_name");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PostalCode");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("State");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Street");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("education_id");

                    b.Property<decimal>("Cgpa")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("cgpa");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("degree");

                    b.Property<DateOnly>("GraduationDate")
                        .HasColumnType("date")
                        .HasColumnName("graduation_date");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("institution");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("major");

                    b.HasKey("Id");

                    b.ToTable("Education", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("email_id");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email_address");

                    b.Property<int>("EmailType")
                        .HasColumnType("int")
                        .HasColumnName("email_type");

                    b.HasKey("Id");

                    b.ToTable("Email", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("experience_id");

                    b.Property<int>("ExperienceLevel")
                        .HasColumnType("int")
                        .HasColumnName("experience_type");

                    b.HasKey("Id");

                    b.ToTable("Experience", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("personname_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext")
                        .HasColumnName("middle_name");

                    b.HasKey("Id");

                    b.ToTable("PersonName", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("phone_id");

                    b.Property<int>("CountryCode")
                        .HasColumnType("int")
                        .HasColumnName("country_code");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("Phone", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("qualification_id");

                    b.Property<string>("QualificationInformation")
                        .HasColumnType("longtext")
                        .HasColumnName("qualification_information");

                    b.Property<int>("QualificationType")
                        .HasColumnType("int")
                        .HasColumnName("qualification_type");

                    b.HasKey("Id");

                    b.ToTable("Qualification", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("skill_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_title");

                    b.HasKey("Id");

                    b.ToTable("SkillModel", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.Role", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("RoleId")
                                .HasColumnType("int");

                            b1.HasKey("RoleId");

                            b1.ToTable("Role");

                            b1.WithOwner()
                                .HasForeignKey("RoleId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("AddressId")
                                .HasColumnType("int");

                            b1.HasKey("AddressId");

                            b1.ToTable("Address");

                            b1.WithOwner()
                                .HasForeignKey("AddressId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("EducationId")
                                .HasColumnType("int");

                            b1.HasKey("EducationId");

                            b1.ToTable("Education");

                            b1.WithOwner()
                                .HasForeignKey("EducationId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("EmailId")
                                .HasColumnType("int");

                            b1.HasKey("EmailId");

                            b1.ToTable("Email");

                            b1.WithOwner()
                                .HasForeignKey("EmailId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("ExperienceId")
                                .HasColumnType("int");

                            b1.HasKey("ExperienceId");

                            b1.ToTable("Experience");

                            b1.WithOwner()
                                .HasForeignKey("ExperienceId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("PersonNameId")
                                .HasColumnType("int");

                            b1.HasKey("PersonNameId");

                            b1.ToTable("PersonName");

                            b1.WithOwner()
                                .HasForeignKey("PersonNameId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("PhoneId")
                                .HasColumnType("int");

                            b1.HasKey("PhoneId");

                            b1.ToTable("Phone");

                            b1.WithOwner()
                                .HasForeignKey("PhoneId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("QualificationId")
                                .HasColumnType("int");

                            b1.HasKey("QualificationId");

                            b1.ToTable("Qualification");

                            b1.WithOwner()
                                .HasForeignKey("QualificationId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("SkillId")
                                .HasColumnType("int");

                            b1.HasKey("SkillId");

                            b1.ToTable("SkillModel");

                            b1.WithOwner()
                                .HasForeignKey("SkillId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
