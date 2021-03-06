﻿using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class DeleteAllNotesCommand : ICommand
    {
        private IDeleteAllNotes note;

        public DeleteAllNotesCommand(IDeleteAllNotes _note)
        {
            note = _note;
        }

        public void ExecuteCommand()
        {
            note.DeleteAll();
        }
    }
}
