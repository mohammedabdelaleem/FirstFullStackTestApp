
const base_URL = "http://localhost:5087/api/students";

// Get all / failed / passed students
const GetAllStudents = async () => {
  try {
    let key = document.getElementById("key")?.value?.toLowerCase() || "all";

    const validRoutes = ["all", "failed", "passed"];
    if (!validRoutes.includes(key)) key = "all";

    const response = await fetch(`${base_URL}/${key}`);
    const students = await response.json();
    let counterId = 1;

    const tableBody = students
      .map(
        (std) => `
        <tr>
          <td>${counterId++}</td>
          <td class="std-id" style="display:none;">${std.id}</td>
          <td>${std.name}</td>
          <td>${std.age}</td>
          <td>${std.grade}</td>
          <td>
            <a class="btn btn-primary edit">Edit</a>
            <a class="btn btn-danger" onclick="deleteStudent('${std.id}', false)">Delete</a>
          </td>
        </tr>`
      )
      .join("");

    document.getElementById("studentsTableBody").innerHTML = tableBody;
  } catch (error) {
    console.error("Error When Getting All Students:", error);
  }
};

// Get student by ID
const GetStudentById = async (id) => {
  try {
    const response = await fetch(`${base_URL}/${id}`);
    return await response.json();
  } catch (error) {
    console.error("Error When Getting Student:", error);
  }
};

// Add new student
const AddNewStudent = async (newUser) => {
  try {
    const response = await fetch(`${base_URL}`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(newUser),
    });

    if (!response.ok) {
      throw new Error(`Server responded with status ${response.status}`);
    }

    const text = await response.text();
    if (text) {
      const addedUser = JSON.parse(text);
      console.log("User Created:", addedUser);
    }
  } catch (error) {
    console.error("Error When Adding Student:", error);
  }
};

// Update student
const UpdateStudent = async (id, updatedUser) => {
  try {
    const response = await fetch(`${base_URL}/${id}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(updatedUser),
    });

    const data = await response.json();
    console.log("User Updated:", data);
  } catch (error) {
    console.error("Error Updating Student:", error);
  }
};

// Delete student
const deleteStudent = async (studentId, redirect = false) => {
  if (confirm("Are you sure you want to delete this student?")) {
    try {
      const response = await fetch(`${base_URL}/${studentId}`, {
        method: "DELETE",
      });

      if (response.ok) {
        alert("Student removed successfully!");
        redirect ? window.location.href = "/" : GetAllStudents();
      } else {
        alert("Failed to delete student");
      }
    } catch (error) {
      console.error("Error deleting student:", error);
      alert("An error occurred while deleting the student.");
    }
  }
};

// -------------------- Form Logic --------------------
const studentForm = document.getElementById("studentForm");
const add = document.querySelector(".add");
const formParent = document.querySelector(".form-parent");
let stdId = '';

// Handle form submission
studentForm.addEventListener("submit", async (eo) => {
  eo.preventDefault();

  const id = stdId;
  const name = document.getElementById("name").value;
  const age = parseInt(document.getElementById("age").value);
  const grade = document.getElementById("grade").value;

  const userData = id ? { id, name, age, grade } : { name, age, grade };
  id ? await UpdateStudent(id, userData) : await AddNewStudent(userData);
  stdId = "";

  eo.target.reset();
  formParent.classList.add("hide");
  GetAllStudents();
});

// Show form on "Add"
add.addEventListener("click", (eo) => {
  eo.preventDefault();
  formParent.classList.remove("hide");
  studentForm.reset();
  document.getElementById("id").value = "";
});

// Edit student
document.getElementById("studentsTableBody").addEventListener("click", async (eo) => {
  if (eo.target.classList.contains("edit")) {
    eo.preventDefault();

    const row = eo.target.closest("tr");
    stdId = row.querySelector(".std-id").textContent;
    const name = row.children[2]?.textContent;
    const age = row.children[3]?.textContent;
    const grade = row.children[4]?.textContent;

    formParent.classList.remove("hide");
    document.getElementById("form-header").innerText = "Edit Student";
    document.getElementById("name").value = name;
    document.getElementById("age").value = age;
    document.getElementById("grade").value = grade;
  }
});

// Close form
document.querySelector(".icon-x").addEventListener("click", () => {
  formParent.classList.add("hide");
  GetAllStudents();
});

document.getElementById("key").addEventListener("change" , (eo) => { 
  
  GetAllStudents()

 })


// Initial load
GetAllStudents();
