

function renderStudents(students) {
  const tableBody = document.getElementById("studentsTableBody");
  tableBody.innerHTML = "";
  let counterId = 1;
  students.forEach(student => {
      let row = document.createElement("tr");

      row.innerHTML = `
          <td>${counterId++}</td>
          <td>${student.name}</td>
          <td>${student.age}</td>
          <td>${student.grade}</td>
          <td>
              <button onclick="handleEdit(${student.id})">Edit</button>
              <td><button class="btn btn-danger" onclick="deleteStudent('${student.id}')">Delete</button></td>
          </td>
      `;

      tableBody.appendChild(row);
  });
}
