﻿using CQRS.EventHandlers;
using CQRS.Implementation.Events;
using DataAccess.Repositories;
using DataAccessDenormalized;
using DataAccessDenormalized.Repository;

namespace CQRS.Implementation.EventHandlers
{
    public class NoteCreatedEventHandler : IEventHandler<NoteCreatedEvent>
    {
        private readonly INoteDenormalizedRepository _noteDenormalizedRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITypeRepository _typeRepository;

        public NoteCreatedEventHandler(INoteDenormalizedRepository noteDenormalizedRepository, 
                                        IUserRepository userRepository, 
                                        ICategoryRepository categoryRepository, 
                                        ITypeRepository typeRepository)
        {
            _noteDenormalizedRepository =  noteDenormalizedRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _typeRepository = typeRepository;
        }
        public void Handle(NoteCreatedEvent handle)
        {
            var user = _userRepository.GetById(handle.UserId);

            string categoryName = null, typeName = null;
            int? categoryId=null;
            if (handle.TypeId != null) { 
                var type = _typeRepository.GetById((int)handle.TypeId);
                var category = _categoryRepository.GetById(type.CategoryId);
                categoryName = category.Name;
                typeName = type.Name;
                categoryId = category.CategoryId;
            }
            
            var item = new note()
            {
                NoteId = handle.NoteId,
                Content = handle.Content,
                Topic = handle.Topic,
                UserId = handle.UserId,
                LocationId = handle.LocationId,
                Date = handle.Date,
                XCord = handle.XCord,
                YCord = handle.YCord,
                ZCord = handle.ZCord,
                Login = user.Login,
                Mail = user.Mail,
                Name = user.Name,
                Identyfication = "NOTE",
                TypeId = handle.TypeId,
                TypeName = typeName,
                CategoryId = categoryId,
                CategoryName = categoryName
            };

            _noteDenormalizedRepository.Add(item);
            _noteDenormalizedRepository.SaveChanges();
        }
    }
}

