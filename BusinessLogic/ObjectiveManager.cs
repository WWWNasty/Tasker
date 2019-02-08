using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    /// <summary>
    /// Менеджер для работы с задачами.
    /// </summary>
    public class ObjectiveManager : IDisposable
    {
        private readonly ObjectiveContext _db;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="objectiveContext">Экземпляр ObjectiveContext</param>
        public ObjectiveManager(ObjectiveContext objectiveContext)
        {
            _db = objectiveContext;
        }

        /// <summary>
        /// Конструктор подключение к бд создается автоматически.
        /// </summary>
        public ObjectiveManager()
        {
            _db = new ObjectiveContext();
        }

        /// <summary>
        /// Получить все задачи.
        /// </summary>
        /// <returns>Перечисление задач.</returns>
        public IEnumerable<Objective> GetAll()
        {
            return _db.Objectives.ToList();
        }

        /// <summary>
        /// Добавить задачу.
        /// </summary>
        /// <param name="objective">Задача</param>
        public void Add(Objective objective)
        {
            _db.Objectives.Add(objective);

            _db.SaveChanges();
        }

        /// <summary>
        /// Поиск задачи.
        /// </summary>
        /// <param name="id">Id задачи.</param>
        /// <returns>Задача.</returns>
        public Objective Find(int id)
        {
            Objective editingObjective = _db.Objectives.Find(id);

            return editingObjective;
        }

        /// <summary>
        /// Редактирование задачи.
        /// </summary>
        /// <param name="editedObjective">Редактируемая задача.</param>
        public void Edit(Objective editedObjective)
        {
            var record = Find(editedObjective.Id);

            record.Name = editedObjective.Name;

            record.Completed = editedObjective.Completed;

            _db.SaveChanges();
        }

        /// <summary>
        /// Удаление задачи.
        /// </summary>
        /// <param name="id">Id удаляемой задачи.</param>
        public void Delete(int id)
        {
            var removingRecord = Find(id);

            _db.Objectives.Remove(removingRecord);

            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}