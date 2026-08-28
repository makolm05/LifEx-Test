document.addEventListener('DOMContentLoaded', function () {
    const sidebar = document.getElementById('pathSidebar');

    // tooltip на мобильных/касаниях: короткий тултип при клике
    sidebar?.addEventListener('click', function (e) {
        const item = e.target.closest('.sidebar-item');
        if (!item) return;
        const name = item.dataset.name;
        // небольшая всплывашка (временная)
        const tip = document.createElement('div');
        tip.textContent = name;
        tip.style.position = 'fixed';
        tip.style.left = (sidebar.getBoundingClientRect().width + 12) + 'px';
        tip.style.top = (e.clientY - 16) + 'px';
        tip.style.padding = '6px 8px';
        tip.style.background = 'rgba(0,0,0,0.8)';
        tip.style.color = '#fff';
        tip.style.borderRadius = '4px';
        tip.style.zIndex = 2000;
        document.body.appendChild(tip);
        setTimeout(() => tip.remove(), 900);
    });

    // Пример: двойной клик по панели — переключить видимость (можете убрать)
    sidebar?.addEventListener('dblclick', function () {
        if (!sidebar) return;
        if (sidebar.style.width === '48px') {
            sidebar.style.width = '';
            document.querySelector('.main-content').style.marginLeft = '';
        } else {
            sidebar.style.width = '48px';
            document.querySelector('.main-content').style.marginLeft = '48px';
        }
    });
});