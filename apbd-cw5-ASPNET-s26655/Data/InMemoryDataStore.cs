using apbd_cw5_ASPNET_s26655.Models;

namespace apbd_cw5_ASPNET_s26655.Data;

public static class InMemoryDataStore
{
    public static List<Room> Rooms { get; } =
    [
        new Room
        {
            Id = 1,
            Name = "Lab 101",
            BuildingCode = "A",
            Floor = 1,
            Capacity = 20,
            HasProjector = true,
            IsActive = true
        },
        new Room
        {
            Id = 2,
            Name = "Lab 204",
            BuildingCode = "B",
            Floor = 2,
            Capacity = 24,
            HasProjector = true,
            IsActive = true
        },
        new Room
        {
            Id = 3,
            Name = "Workshop Room 12",
            BuildingCode = "A",
            Floor = 1,
            Capacity = 12,
            HasProjector = false,
            IsActive = true
        },
        new Room
        {
            Id = 4,
            Name = "Conference Hall",
            BuildingCode = "C",
            Floor = 0,
            Capacity = 50,
            HasProjector = true,
            IsActive = false
        },
        new Room
        {
            Id = 5,
            Name = "Seminar Room 7",
            BuildingCode = "B",
            Floor = 3,
            Capacity = 16,
            HasProjector = false,
            IsActive = true
        }
    ];

    public static List<Reservation> Reservations { get; } =
    [
        new Reservation
        {
            Id = 1,
            RoomId = 1,
            OrganizerName = "Anna Kowalska",
            Topic = "SQL Basics Workshop",
            Date = new DateOnly(2026, 5, 10),
            StartTime = new TimeOnly(9, 0),
            EndTime = new TimeOnly(11, 0),
            Status = "confirmed"
        },
        new Reservation
        {
            Id = 2,
            RoomId = 2,
            OrganizerName = "Jan Nowak",
            Topic = "REST API Consultation",
            Date = new DateOnly(2026, 5, 10),
            StartTime = new TimeOnly(12, 0),
            EndTime = new TimeOnly(13, 30),
            Status = "planned"
        },
        new Reservation
        {
            Id = 3,
            RoomId = 3,
            OrganizerName = "Maria Zielinska",
            Topic = "Frontend Review Session",
            Date = new DateOnly(2026, 5, 11),
            StartTime = new TimeOnly(10, 0),
            EndTime = new TimeOnly(12, 0),
            Status = "confirmed"
        },
        new Reservation
        {
            Id = 4,
            RoomId = 5,
            OrganizerName = "Piotr Adamski",
            Topic = "Testing Workshop",
            Date = new DateOnly(2026, 5, 12),
            StartTime = new TimeOnly(14, 0),
            EndTime = new TimeOnly(16, 0),
            Status = "cancelled"
        },
        new Reservation
        {
            Id = 5,
            RoomId = 1,
            OrganizerName = "Katarzyna Wisniewska",
            Topic = "HTTP and REST Workshop",
            Date = new DateOnly(2026, 5, 13),
            StartTime = new TimeOnly(8, 30),
            EndTime = new TimeOnly(10, 0),
            Status = "confirmed"
        }
    ];
}