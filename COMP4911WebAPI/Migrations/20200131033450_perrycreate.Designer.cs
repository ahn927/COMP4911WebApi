﻿// <auto-generated />
using System;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP4911WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200131033450_perrycreate")]
    partial class perrycreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP4911WebAPI.Models.Credential", b =>
                {
                    b.Property<string>("CredentialId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Password");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.HasKey("CredentialId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeFirstName");

                    b.Property<string>("EmployeeLastName");

                    b.Property<bool>("IsActivated");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsHumanResources");

                    b.Property<bool>("IsProjectManager");

                    b.Property<int>("JobId");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.Property<int?>("SupervisorId");

                    b.Property<int?>("TimesheetApproverId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("TimesheetApproverId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.EmployeeProjectAssignment", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("ProjectId");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjectAssignments");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.EmployeeWorkPackageAssignment", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int?>("WorkPackageId");

                    b.Property<int>("ProjectId");

                    b.HasKey("EmployeeId", "WorkPackageId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("WorkPackageId", "ProjectId");

                    b.ToTable("EmployeeWorkPackageAssignments");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobTitleName");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectName");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.Property<int>("WeekNumber");

                    b.HasKey("TimesheetId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Timesheet");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.TimesheetRow", b =>
                {
                    b.Property<int>("TimesheetRowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Friday");

                    b.Property<int>("Monday");

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.Property<int>("Saturday");

                    b.Property<int>("Sunday");

                    b.Property<int>("Thursday");

                    b.Property<int>("TimesheetId");

                    b.Property<int>("Tuesday");

                    b.Property<int>("Wednesday");

                    b.Property<int>("WorkPackageId");

                    b.HasKey("TimesheetRowId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TimesheetId");

                    b.HasIndex("WorkPackageId", "ProjectId");

                    b.ToTable("TimesheetRows");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.WorkPackage", b =>
                {
                    b.Property<int>("WorkPackageId");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Activities");

                    b.Property<string>("Contractor");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Inputs");

                    b.Property<string>("Outputs");

                    b.Property<int?>("ParentWorkPackageId");

                    b.Property<string>("Purpose");

                    b.Property<int>("ResponsibleEngineerId");

                    b.Property<DateTime>("Row_Lst_Upd_Ts");

                    b.Property<string>("Row_Lst_Upd_Uid");

                    b.Property<DateTime>("StartDate");

                    b.Property<double?>("WorkPackageCost");

                    b.Property<string>("WorkPackageDescription");

                    b.Property<string>("WorkPackageName");

                    b.HasKey("WorkPackageId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ParentWorkPackageId", "ProjectId");

                    b.ToTable("WorkPackages");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Credential", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Employee", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Employee", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");

                    b.HasOne("COMP4911WebAPI.Models.Employee", "TimesheetApprover")
                        .WithMany()
                        .HasForeignKey("TimesheetApproverId");
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.EmployeeProjectAssignment", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Employee", "Employee")
                        .WithMany("EmployeeProjectAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.Project", "Project")
                        .WithMany("EmployeeProjectAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.EmployeeWorkPackageAssignment", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Employee", "Employee")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.Project", "Project")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.WorkPackage", "WorkPackage")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("WorkPackageId", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.Timesheet", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Employee", "Employee")
                        .WithOne("Timesheet")
                        .HasForeignKey("COMP4911WebAPI.Models.Timesheet", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.TimesheetRow", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.Timesheet", "Timesheet")
                        .WithMany("TimesheetRows")
                        .HasForeignKey("TimesheetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.WorkPackage", "WorkPackage")
                        .WithMany("TimesheetRows")
                        .HasForeignKey("WorkPackageId", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP4911WebAPI.Models.WorkPackage", b =>
                {
                    b.HasOne("COMP4911WebAPI.Models.Project", "Project")
                        .WithMany("WorkPackages")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("COMP4911WebAPI.Models.WorkPackage", "ParentWorkPackage")
                        .WithMany("ChildrenWorkPackages")
                        .HasForeignKey("ParentWorkPackageId", "ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
