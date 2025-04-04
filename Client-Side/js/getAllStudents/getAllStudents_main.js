


document.addEventListener("DOMContentLoaded", async () => {
  const students = await getStudents();
  renderStudents(students);
});
