﻿(function () {
    "use strict";

    WinJS.UI.Pages.define("pages/home/home.html", {

        ready: function (element, options) {

            var noteService = new NoteService();

            var NotesListViewModel = function () {
                var self = this;
                self.myNotesArray = ko.observableArray([]);
                self.lastRefresh = ko.observable();

                self.selectedCategoryId = ko.observable();
                self.selectedTypeId = ko.observable();

                self.categories = ko.observableArray([]);
                self.types = ko.computed(function () {
                    self.selectedTypeId(null);
                    $('#typeSelect').trigger('change');
                    if (self.selectedCategoryId()) {
                        var selectedCategoryItem = $.grep(self.categories(), function (n, i) {
                            return n.CategoryId() == self.selectedCategoryId();
                        });

                        if (selectedCategoryItem.length > 0) {
                            return selectedCategoryItem[0].Types();
                        }
                    }
                        return null;
                });

                var getNotes = function () {
                    noteService.getUserNotes(function (data) {
                        self.myNotesArray(data);
                        self.lastRefresh(new Date());
                    });
                };

                var searchNotes = function () {

                    var options = {
                        enableHighAccuracy: true
                    };

                    navigator.geolocation.getCurrentPosition(function (position) {
                        var longitude = position.coords.longitude;
                        var latitude = position.coords.latitude;
                        var altitude = position.coords.altitude;

                        alert("longitude " + longitude);
                        alert("latitude " + latitude);
                        alert("altitude " + altitude);

                        noteService.getNotesByLocation(function (data) {
                            self.myNotesArray(data);
                            self.lastRefresh(new Date());
                        }, longitude, latitude, 20, self.selectedCategoryId(), self.selectedTypeId());

                    }, function () {
                        alert("error");
                    }, options);
                };

                var getMyNotesViewModel = function () {
                    noteService.getMyNotesViewModel(function (data) {
                        self.categories(data.Categories());
                        self.myNotesArray(data.Notes());
                        self.lastRefresh(new Date());
                    });
                };

                self.showOnMap = function (item) {
                    item.IsSelected(true);
                    gotoMap();
                };

                self.edit = function (item) {
                    WinJS.Navigation.navigate('pages/note/note.html', { id: item.NoteId() });
                };

                self.delete = function (item) {
                    noteService.deleteNote(item);
                };

                self.gotoAddNote = function () {
                    WinJS.Navigation.navigate('pages/note/note.html', { id: 0 });
                };

                self.refresh = function () {
                    getNotes();
                };

                self.search = function () {
                    searchNotes();
                };

                var gotoMap = function () {
                    WinJS.Navigation.navigate('pages/map/map.html', {
                        Notes: self.myNotesArray(),
                        BackLink: 'pages/home/home.html'
                    });
                };

                self.showNotesOnMap = function () {
                    gotoMap();
                };

                getMyNotesViewModel();

            };

            var notesListViewModel = new NotesListViewModel();
            ko.applyBindings(notesListViewModel, document.getElementById("notes-container"));

        }
    });
})();
