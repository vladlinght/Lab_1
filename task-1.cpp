#include <windows.h>
#include <iostream>
#include <vector>
#include <string>

void createAndManageProcess(const std::string& programName, DWORD timeoutMs) {
    STARTUPINFOA si = { sizeof(STARTUPINFOA) };
    PROCESS_INFORMATION pi = { 0 };

    // Створення процесу
    if (!CreateProcessA(
        programName.c_str(),       // Ім'я програми
        NULL,                      // Аргументи командного рядка
        NULL,                      // Дескриптор безпеки для процесу
        NULL,                      // Дескриптор безпеки для потоку
        FALSE,                     // Успадкування дескрипторів
        0,                         // Стиль створення
        NULL,                      // Середовище процесу
        NULL,                      // Робоча директорія
        &si,                       // Інформація про запуск
        &pi                        // Інформація про процес
    )) {
        std::cerr << "Помилка створення процесу. Код помилки: " << GetLastError() << std::endl;
        return;
    }

    std::cout << "Процес " << programName << " успішно створено. Очікуємо завершення..." << std::endl;

    // Очікування завершення процесу
    DWORD waitResult = WaitForSingleObject(pi.hProcess, timeoutMs);
    if (waitResult == WAIT_TIMEOUT) {
        std::cout << "Час виконання процесу перевищено. Завершуємо..." << std::endl;
        TerminateProcess(pi.hProcess, 1);
    }

    // Отримання коду завершення процесу
    DWORD exitCode = 0;
    if (GetExitCodeProcess(pi.hProcess, &exitCode)) {
        std::cout << "Процес завершено. Код завершення: " << exitCode << std::endl;
    } else {
        std::cerr << "Не вдалося отримати код завершення. Код помилки: " << GetLastError() << std::endl;
    }

    // Закриття дескрипторів процесу і потоку
    CloseHandle(pi.hProcess);
    CloseHandle(pi.hThread);
}

int main() {
    // Перелік програм для запуску
    std::vector<std::string> programs = { "notepad.exe", "calc.exe" };

    // Таймаут для виконання процесу
    DWORD timeoutMs = 10000; // 10 секунд

    for (const auto& program : programs) {
        createAndManageProcess(program, timeoutMs);
    }

    return 0;
}
