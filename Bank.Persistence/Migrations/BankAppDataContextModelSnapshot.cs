﻿// <auto-generated />
using System;
using Bank.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bank.Persistence.Migrations
{
    [DbContext(typeof(BankAppDataContext))]
    partial class BankAppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bank.Domain.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Balance")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AccountId")
                        .HasName("PK_account");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ccnumber")
                        .IsRequired()
                        .HasColumnName("CCNumber")
                        .HasMaxLength(50);

                    b.Property<string>("Cctype")
                        .IsRequired()
                        .HasColumnName("CCType")
                        .HasMaxLength(50);

                    b.Property<string>("Cvv2")
                        .IsRequired()
                        .HasColumnName("CVV2")
                        .HasMaxLength(10);

                    b.Property<int>("DispositionId");

                    b.Property<int>("ExpM");

                    b.Property<int>("ExpY");

                    b.Property<DateTime>("Issued")
                        .HasColumnType("date");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CardId");

                    b.HasIndex("DispositionId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Emailaddress")
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Givenname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NationalId")
                        .HasMaxLength(20);

                    b.Property<string>("Streetaddress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telephonecountrycode")
                        .HasMaxLength(10);

                    b.Property<string>("Telephonenumber")
                        .HasMaxLength(25);

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Disposition", b =>
                {
                    b.Property<int>("DispositionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DispositionId")
                        .HasName("PK_disposition");

                    b.HasIndex("AccountId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Dispositions");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Duration");

                    b.Property<decimal>("Payments")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("LoanId")
                        .HasName("PK_loan");

                    b.HasIndex("AccountId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Bank.Domain.Entities.PermenentOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<string>("AccountTo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<string>("BankTo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("OrderId");

                    b.HasIndex("AccountId");

                    b.ToTable("PermenentOrder");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasMaxLength(50);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(13, 2)");

                    b.Property<string>("Bank")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Symbol")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TransactionId")
                        .HasName("PK_trans2");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Card", b =>
                {
                    b.HasOne("Bank.Domain.Entities.Disposition", "Disposition")
                        .WithMany("Cards")
                        .HasForeignKey("DispositionId")
                        .HasConstraintName("FK_Cards_Dispositions");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Disposition", b =>
                {
                    b.HasOne("Bank.Domain.Entities.Account", "Account")
                        .WithMany("Dispositions")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Dispositions_Accounts");

                    b.HasOne("Bank.Domain.Entities.Customer", "Customer")
                        .WithMany("Dispositions")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Dispositions_Customers");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Loan", b =>
                {
                    b.HasOne("Bank.Domain.Entities.Account", "Account")
                        .WithMany("Loans")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Loans_Accounts");
                });

            modelBuilder.Entity("Bank.Domain.Entities.PermenentOrder", b =>
                {
                    b.HasOne("Bank.Domain.Entities.Account", "Account")
                        .WithMany("PermenentOrders")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_PermenentOrder_Accounts");
                });

            modelBuilder.Entity("Bank.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("Bank.Domain.Entities.Account", "AccountNavigation")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Transactions_Accounts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
