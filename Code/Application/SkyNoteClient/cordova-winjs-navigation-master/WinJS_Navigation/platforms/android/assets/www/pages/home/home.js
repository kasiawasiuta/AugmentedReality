﻿// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    WinJS.UI.Pages.define("pages/home/home.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // TODO: Initialize the page here.

            var elem = document.querySelector(".navButton");
            elem.addEventListener('click', this.btnHandler);

            var noteService = new NoteService();

            var NotesListViewModel = function () {
                var self = this;
                self.myNotesArray = ko.observableArray([]);

            };

            var notesListViewModel = new NotesListViewModel();
            noteService.getUserNotes(function (data) {
                notesListViewModel.myNotesArray(data);
            })

            ko.applyBindings(notesListViewModel, document.getElementById("notes-content"));

        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        },

        btnHandler: function (args) {
            WinJS.Navigation.navigate('pages/note/note.html', args);
        }

    });
})();