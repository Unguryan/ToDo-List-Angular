import { NotifierOptions } from "angular-notifier";

export const environment = {
  Backend_API: "http://localhost:5000/",
  signalRHub: "http://localhost:5000/notificationsHub"
};

export const notifierOptions: NotifierOptions = {
  position: {
    horizontal: {
      position: 'right',
      distance: 15,
    },
    vertical: {
      position: 'top',
      distance: 70,
      gap: 10,
    },
  },
  theme: 'material',
  behaviour: {
    autoHide: 5000,
    onClick: false,
    onMouseover: 'pauseAutoHide',
    showDismissButton: true,
    stacking: 4,
  },
  animations: {
    enabled: true,
    show: {
      preset: 'slide',
      speed: 300,
      easing: 'ease',
    },
    hide: {
      preset: 'fade',
      speed: 300,
      easing: 'ease',
      offset: 50,
    },
    shift: {
      speed: 300,
      easing: 'ease',
    },
    overlap: 150,
  },
};