function y = evalua_recta(r, x);
% Calculo de la ecuación d ela recta
m = (r.p1.y - r.p2.y)/(r.p1.x - r.p2.x);
n = r.p1.y - m*r.p1.x;
% Evaluar el punto dado
y = m * x + n;