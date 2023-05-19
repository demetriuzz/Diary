using AutoMapper;
using Diary.Application.Interfaces;
using Diary.Application.Models;
using Diary.Domain.Entities;

namespace Diary.Application.Services;

public class NoteEntityService : INoteEntityService
{
    private INoteRepository _noteRepository;
    private IMapper _mapper;

    public NoteEntityService(INoteRepository noteRepository, IMapper mapper)
    {
        _noteRepository = noteRepository;
        _mapper = mapper;
    }

    public NoteEntity AddNote(NoteEntity entity)
    {
        var note = _noteRepository.Add(_mapper.Map<Note>(entity));
        return _mapper.Map<NoteEntity>(note);
    }

    public void DeleteNote(int id)
    {
        _noteRepository.Delete(id);
    }

    public List<NoteEntity> GetNotes()
    {
        return _mapper.Map<List<NoteEntity>>(_noteRepository.GetAll());
    }

    public NoteEntity GetNoteById(int id)
    {
        var note = _noteRepository.GetById(id);
        return _mapper.Map<NoteEntity>(note);
    }

    public NoteEntity UpdateNote(NoteEntity entity)
    {
        var note = _noteRepository.Update(_mapper.Map<Note>(entity));
        return _mapper.Map<NoteEntity>(note);
    }
}