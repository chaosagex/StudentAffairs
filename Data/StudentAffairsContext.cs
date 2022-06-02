using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StudentAffairs.Models;

namespace StudentAffairs.Data
{
    public partial class StudentAffairsContext : DbContext
    {
        public StudentAffairsContext()
        {
        }

        public StudentAffairsContext(DbContextOptions<StudentAffairsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Govenante> Govenantes { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Guardian> Guardians { get; set; } = null!;
        public virtual DbSet<JoinYear> JoinYears { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Nationality> Nationalities { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<Religion> Religions { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\sqlexpress;database=Student Affairs;Trusted_connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branches");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branch_name");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("classes");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.ClassGrade).HasColumnName("class_grade");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("class_name");

                entity.HasOne(d => d.ClassGradeNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.ClassGrade)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_classes_grades");
            });

            modelBuilder.Entity<Govenante>(entity =>
            {
                entity.HasKey(e => e.GovId);

                entity.ToTable("govenante");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.GovName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gov_name");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grades");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grade_name");
            });

            modelBuilder.Entity<Guardian>(entity =>
            {
                entity.ToTable("guardian");

                entity.Property(e => e.GuardianId).HasColumnName("guardian_id");

                entity.Property(e => e.GuardianName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("guardian_name");
            });

            modelBuilder.Entity<JoinYear>(entity =>
            {
                entity.ToTable("joinYear");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("language_name");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.HasKey(e => e.NatId);

                entity.ToTable("nationality");

                entity.Property(e => e.NatId).HasColumnName("nat_id");

                entity.Property(e => e.NatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nat_name");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("parents");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.ParentArabicName)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasColumnName("parent_arabic_name");

                entity.Property(e => e.ParentEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("parent_email");

                entity.Property(e => e.ParentEnglishName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parent_english_name");

                entity.Property(e => e.ParentJob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parent_job");

                entity.Property(e => e.ParentJobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("parent_job_location");

                entity.Property(e => e.ParentLanguage).HasColumnName("parent_language");

                entity.Property(e => e.ParentMobilephone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("parent_mobilephone");

                entity.Property(e => e.ParentNationality).HasColumnName("parent_nationality");

                entity.Property(e => e.ParentNid)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("parent_nid")
                    .IsFixedLength();

                entity.Property(e => e.ParentPassport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parent_passport");

                entity.Property(e => e.ParentQualification).HasColumnName("parent_qualification");

                entity.Property(e => e.ParentType).HasColumnName("parent_type");

                entity.HasOne(d => d.ParentLanguageNavigation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.ParentLanguage)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_parents_languages");

                entity.HasOne(d => d.ParentNationalityNavigation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.ParentNationality)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_parents_nationality");

                entity.HasOne(d => d.ParentQualificationNavigation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.ParentQualification)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_parents_qualifications");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("qualifications");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("religions");

                entity.Property(e => e.ReligionId).HasColumnName("religion_id");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("religion_name");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status_name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.AppliedBefore).HasColumnName("applied_before");

                entity.Property(e => e.ApplyingForGrade).HasColumnName("applyingForGrade");

                entity.Property(e => e.BirthCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("birth_code");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("birth_place");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emergency_contact");

                entity.Property(e => e.EmergencyPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emergency_phone");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Guardian).HasColumnName("guardian");

                entity.Property(e => e.HaveSibling).HasColumnName("have_sibling");

                entity.Property(e => e.JoinYear).HasColumnName("join_year");

                entity.Property(e => e.LeavingReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("leaving_reason");

                entity.Property(e => e.OldSchool)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_school");

                entity.Property(e => e.OldSchoolNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_school_number");

                entity.Property(e => e.ParentsSeparated).HasColumnName("parents_separated");

                entity.Property(e => e.ReferenceName1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference_name1");

                entity.Property(e => e.ReferenceName2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference_name2");

                entity.Property(e => e.ReferencePhone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference_phone1");

                entity.Property(e => e.ReferencePhone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference_phone2");

                entity.Property(e => e.Religon).HasColumnName("religon");

                entity.Property(e => e.SchoolAbrev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("school_abrev");

                entity.Property(e => e.StaffSon).HasColumnName("staff_son");

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("student_address");

                entity.Property(e => e.StudentAffairs1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_affairs1");

                entity.Property(e => e.StudentAffairs2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_affairs2");

                entity.Property(e => e.StudentArabicFName)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasColumnName("student_arabic_fName");

                entity.Property(e => e.StudentArabicFmName)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasColumnName("student_arabic_fmName");

                entity.Property(e => e.StudentArabicLName)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasColumnName("student_arabic_lName");

                entity.Property(e => e.StudentArabicMName)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .HasColumnName("student_arabic_mName");

                entity.Property(e => e.StudentBranch).HasColumnName("student_branch");

                entity.Property(e => e.StudentClass).HasColumnName("student_class");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_code");

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("student_email");

                entity.Property(e => e.StudentEnglishFName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_english_fName");

                entity.Property(e => e.StudentEnglishFmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_english_fmName");

                entity.Property(e => e.StudentEnglishLName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_english_lName");

                entity.Property(e => e.StudentEnglishMName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_english_mName");

                entity.Property(e => e.StudentFather).HasColumnName("student_father");

                entity.Property(e => e.StudentGov).HasColumnName("student_gov");

                entity.Property(e => e.StudentGrade).HasColumnName("student_grade");

                entity.Property(e => e.StudentMother).HasColumnName("student_mother");

                entity.Property(e => e.StudentNat).HasColumnName("student_nat");

                entity.Property(e => e.StudentNid)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("student_nid")
                    .IsFixedLength();

                entity.Property(e => e.StudentPassport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_passport");

                entity.Property(e => e.StudentPassword)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("student_password")
                    .IsFixedLength();

                entity.Property(e => e.StudentStatus).HasColumnName("student_status");

                entity.Property(e => e.StudentUpdate).HasColumnName("student_update");

                entity.Property(e => e.SubscribeBus).HasColumnName("subscribe_bus");

                entity.HasOne(d => d.ApplyingForGradeNavigation)
                    .WithMany(p => p.StudentApplyingForGradeNavigations)
                    .HasForeignKey(d => d.ApplyingForGrade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_students_grades_applyingfor");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_cities");

                entity.HasOne(d => d.GuardianNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Guardian)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_guardian");

                entity.HasOne(d => d.JoinYearNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.JoinYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_students_joinYear");

                entity.HasOne(d => d.ReligonNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Religon)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_religions");

                entity.HasOne(d => d.StudentBranchNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentBranch)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_branches");

                entity.HasOne(d => d.StudentClassNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentClass)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_classes");

                entity.HasOne(d => d.StudentFatherNavigation)
                    .WithMany(p => p.StudentStudentFatherNavigations)
                    .HasForeignKey(d => d.StudentFather)
                    .HasConstraintName("FK_students_Father");

                entity.HasOne(d => d.StudentGovNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentGov)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_govenante");

                entity.HasOne(d => d.StudentGradeNavigation)
                    .WithMany(p => p.StudentStudentGradeNavigations)
                    .HasForeignKey(d => d.StudentGrade)
                    .HasConstraintName("FK_students_grades");

                entity.HasOne(d => d.StudentMotherNavigation)
                    .WithMany(p => p.StudentStudentMotherNavigations)
                    .HasForeignKey(d => d.StudentMother)
                    .HasConstraintName("FK_students_Mother");

                entity.HasOne(d => d.StudentNatNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentNat)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_nationality");

                entity.HasOne(d => d.StudentStatusNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentStatus)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
