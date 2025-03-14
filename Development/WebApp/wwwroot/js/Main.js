function toggleSidebar() {
    let sidebar = document.getElementById('sidebar');
    let toggleIcon = document.getElementById('toggleIcon');
    sidebar.classList.toggle('collapsed');
    document.querySelector('.content').classList.toggle('collapsed');
    if (sidebar.classList.contains('collapsed')) {
        toggleIcon.classList.remove('fa-times');
        toggleIcon.classList.add('fa-bars');
    } else {
        toggleIcon.classList.remove('fa-bars');
        toggleIcon.classList.add('fa-times');
    }
}
