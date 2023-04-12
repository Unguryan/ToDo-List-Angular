import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[spin-hover]'
})
export class HoverDirective {

  constructor(public elementRef: ElementRef) { }

  @HostListener('mouseenter') onMouseEnter() {
      this.elementRef.nativeElement.classList.add("pi-spin");
  }

  @HostListener('mouseleave') onMouseLeave() {
      this.elementRef.nativeElement.classList.remove("pi-spin");
  }
}
