﻿// <auto-generated />
using System;
using HellDiver2_API2DB.EntFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HD2_EFDatabase.Migrations
{
    [DbContext(typeof(DB_Context))]
    partial class DB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Campaign2", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long>("FK_Planet_ID")
                        .HasColumnType("bigint");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("PK_id");

                    b.HasIndex("FK_Planet_ID");

                    b.ToTable("campaign2s");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Dispatch", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("published")
                        .HasColumnType("datetime2");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("PK_id");

                    b.ToTable("dispatches");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Planet", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FK_Events_ID")
                        .HasColumnType("bigint");

                    b.Property<long>("FK_Position_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("FK_Stats_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("currentOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("disabled")
                        .HasColumnType("bit");

                    b.Property<long>("hash")
                        .HasColumnType("bigint");

                    b.Property<long>("health")
                        .HasColumnType("bigint");

                    b.Property<int>("index")
                        .HasColumnType("int");

                    b.Property<string>("initialOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("maxHealth")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("regenPerSecond")
                        .HasColumnType("float");

                    b.Property<string>("sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("waypoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_id");

                    b.HasIndex("FK_Events_ID");

                    b.HasIndex("FK_Position_ID");

                    b.HasIndex("FK_Stats_ID");

                    b.ToTable("planets");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Reward", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("PK_id");

                    b.ToTable("rewards");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Statistics", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long>("accuracy")
                        .HasColumnType("bigint");

                    b.Property<long>("automatonKills")
                        .HasColumnType("bigint");

                    b.Property<long>("bulletsFired")
                        .HasColumnType("bigint");

                    b.Property<long>("bulletsHit")
                        .HasColumnType("bigint");

                    b.Property<long>("deaths")
                        .HasColumnType("bigint");

                    b.Property<long>("friendlies")
                        .HasColumnType("bigint");

                    b.Property<long>("illuminateKills")
                        .HasColumnType("bigint");

                    b.Property<long>("missionSuccessRate")
                        .HasColumnType("bigint");

                    b.Property<long>("missionTime")
                        .HasColumnType("bigint");

                    b.Property<long>("missionsLost")
                        .HasColumnType("bigint");

                    b.Property<long>("missionsWon")
                        .HasColumnType("bigint");

                    b.Property<long>("playerCount")
                        .HasColumnType("bigint");

                    b.Property<long>("revives")
                        .HasColumnType("bigint");

                    b.Property<long>("terminidKills")
                        .HasColumnType("bigint");

                    b.Property<long>("timePlayed")
                        .HasColumnType("bigint");

                    b.HasKey("PK_id");

                    b.ToTable("statistics");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.WarInfo", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FK_Stats_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("clientVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ended")
                        .HasColumnType("datetime2");

                    b.Property<string>("factions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("impactMultiplier")
                        .HasColumnType("float");

                    b.Property<DateTime>("now")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("started")
                        .HasColumnType("datetime2");

                    b.HasKey("PK_id");

                    b.HasIndex("FK_Stats_ID");

                    b.ToTable("warInfos");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.assignmentData", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long>("FK_Reward_ID")
                        .HasColumnType("bigint");

                    b.Property<long>("FK_Task_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("briefing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("id")
                        .HasColumnType("bigint");

                    b.Property<string>("progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_id");

                    b.HasIndex("FK_Reward_ID");

                    b.ToTable("assignmentDatas");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.eventData", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long>("campaignId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("endTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("eventType")
                        .HasColumnType("int");

                    b.Property<string>("faction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("health")
                        .HasColumnType("bigint");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("joinOperationIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("maxHealth")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PK_id");

                    b.ToTable("eventDatas");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.steamData", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("publishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_id");

                    b.ToTable("steamDatas");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.taskData", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FK_Task_ID")
                        .HasColumnType("bigint");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("valueTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("values")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_id");

                    b.HasIndex("FK_Task_ID");

                    b.ToTable("taskDatas");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.xyPosition", b =>
                {
                    b.Property<long>("PK_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntryTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<double>("x")
                        .HasColumnType("float");

                    b.Property<double>("y")
                        .HasColumnType("float");

                    b.HasKey("PK_id");

                    b.ToTable("xyPositions");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Campaign2", b =>
                {
                    b.HasOne("HellDiver2_API2DB.V1_Objects.Planet", "planet")
                        .WithMany()
                        .HasForeignKey("FK_Planet_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("planet");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.Planet", b =>
                {
                    b.HasOne("HellDiver2_API2DB.V1_Objects.eventData", "events")
                        .WithMany()
                        .HasForeignKey("FK_Events_ID");

                    b.HasOne("HellDiver2_API2DB.V1_Objects.xyPosition", "position")
                        .WithMany()
                        .HasForeignKey("FK_Position_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HellDiver2_API2DB.V1_Objects.Statistics", "statistics")
                        .WithMany()
                        .HasForeignKey("FK_Stats_ID");

                    b.Navigation("events");

                    b.Navigation("position");

                    b.Navigation("statistics");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.WarInfo", b =>
                {
                    b.HasOne("HellDiver2_API2DB.V1_Objects.Statistics", "statistics")
                        .WithMany()
                        .HasForeignKey("FK_Stats_ID");

                    b.Navigation("statistics");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.assignmentData", b =>
                {
                    b.HasOne("HellDiver2_API2DB.V1_Objects.Reward", "reward")
                        .WithMany()
                        .HasForeignKey("FK_Reward_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("reward");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.taskData", b =>
                {
                    b.HasOne("HellDiver2_API2DB.V1_Objects.assignmentData", null)
                        .WithMany("tasks")
                        .HasForeignKey("FK_Task_ID");
                });

            modelBuilder.Entity("HellDiver2_API2DB.V1_Objects.assignmentData", b =>
                {
                    b.Navigation("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
