# Cinema Track 

## Summary
This is a small desktop application developed using **C#** and **Windows Forms** that allows users to manage cinemas. It is designed using a **3-layer architecture** (Model, Repository, Service) and implements the following features:

- Register cinemas with properties such as name, address, area, manager, and room count.
- List all registered cinemas in a `DataGridView`.
- Delete cinemas from the list.
- Search cinemas by any property (excluding the code).
- Sort cinemas by different properties.
- Avoid duplicate cinema codes during registration.

## Features
- **3-layer architecture**:
  - **Model**: Defines the `Cinema` class with properties like code, name, address, etc.
  - **Repository**: In-memory storage for cinemas.
  - **Service**: Business logic for cinema management, including validation and sorting.
  
- **Windows Forms**:
  - Form-based UI for registering, listing, searching, and deleting cinemas.
  - Uses `DataGridView` to display cinema data in a table format.
  
- **No Try-Catch**: The project does not use `try-catch` blocks, following clean exception handling practices.

## Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/cinema-maintenance-system.git
    ```
2. Open the solution in **Visual Studio**.
3. Build and run the project to start managing cinemas.

## Usage
1. **Register Cinema**: Fill in the form and click "Register".
2. **List Cinemas**: View the list of cinemas in the table.
3. **Delete Cinema**: Select a cinema from the list and click "Delete".
4. **Search Cinemas**: Filter cinemas based on a specific property.
5. **Sort Cinemas**: Order cinemas by a chosen property.

## Contributing
Feel free to fork this repository, submit issues, or create pull requests if you'd like to contribute improvements or additional features.

---

## Author
Gonzalo Andre Zavala Quedena
