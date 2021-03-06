﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wbcl.DAL.Context;

namespace Wbcl.DAL.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20210301102221_addTimetoMessageLog")]
    partial class addTimetoMessageLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("monitor")
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Wbcl.Core.Models.Database.ChatHistoryItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("MessageText")
                        .HasColumnType("text");

                    b.Property<DateTime>("Sent")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("ToUser")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MessagesLog");
                });

            modelBuilder.Entity("Wbcl.Core.Models.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CurrentTargetId")
                        .HasColumnType("bigint");

                    b.Property<string>("CurrentTargetName")
                        .HasColumnType("text");

                    b.Property<int?>("CurrentTargetType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndOfAdvancedSubscription")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Keyword")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wbcl.Core.Models.Database.UserPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Keyword")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastNotifiedPostTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("TargetId")
                        .HasColumnType("bigint");

                    b.Property<string>("TargetName")
                        .HasColumnType("text");

                    b.Property<int>("TargetType")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("Wbcl.Core.Models.Database.ChatHistoryItem", b =>
                {
                    b.HasOne("Wbcl.Core.Models.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Wbcl.Core.Models.Database.UserPreference", b =>
                {
                    b.HasOne("Wbcl.Core.Models.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
