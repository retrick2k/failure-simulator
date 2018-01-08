namespace FailureSimulator.Core.IO
{
    /// <summary>
    /// Интерфейс парсера проектов
    /// </summary>
    public interface IProjectParser
    {
        /// <summary>
        /// Читает проект из файла
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns></returns>
        SimulationProject ReadProject(string filename);

        /// <summary>
        /// Сохраняет проект в файл
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="project">Проект</param>
        void SaveProject(string filename, SimulationProject project);
    }
}