x = [40, 110, 100, 50, 40];
y = [40, 40, 60, 60, 40];
brazo.p1.x = 0; brazo.p1.y = 0;
brazo.p2.x = 21; brazo.p2.y = 26;
p.x = x(1); p.y = y(1); O.ptos(1) = p;
p.x = x(2); p.y = y(2); O.ptos(2) = p;
p.x = x(3); p.y = y(3); O.ptos(3) = p;
p.x = x(4); p.y = y(4); O.ptos(4) = p;

obst = obstaculo_crecido(brazo, O.ptos);
plot(x, y, 'b');
n = max(size(obst));
for i=1:n
    x(i) = obst(i).x;
    y(i) = obst(i).y;
end
hold on
x = [x x(1)];
y = [y y(1)];
plot(x, y, 'r');