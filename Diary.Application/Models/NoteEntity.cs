﻿namespace Diary.Application.Models;

/// <summary>
/// What need do
/// </summary>
public class NoteEntity
{

    public int Id { get; set; }

    /// <summary>
    /// When need do: day in year
    /// </summary>
    public DateOnly Day { get; set; }

    /// <summary>
    /// When need do: time
    /// </summary>
    public TimeOnly? Time { get; set; }

    /// <summary>
    /// What do it
    /// </summary>
    public string? ToDo { get; set; }

}