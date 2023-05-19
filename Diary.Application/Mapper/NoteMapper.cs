using AutoMapper;
using Diary.Application.Models;
using Diary.Domain.Entities;

namespace Diary.Application.Mapper;

public class NoteMapper : Profile
{
    public NoteMapper()
    {
        CreateMap<Note, NoteEntity>();
        CreateMap<NoteEntity, Note>();
    }
}