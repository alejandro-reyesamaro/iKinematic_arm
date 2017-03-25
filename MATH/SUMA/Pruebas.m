% Esta funcion solo se utiliza para probar los codigos 

brazo.p1.x = 0;
brazo.p1.y = 0;
brazo.p2.x = 1;
brazo.p2.y = 2;
xb = [brazo.p1.x brazo.p2.x];
yb = [brazo.p1.y brazo.p2.y];

% DIFERENTES EJEMPLOS DE OBSTACULOS
% M = [3 6 6 3; 
%      4 6 8 7];
% M = [5 6 5 3; 
%      3 4 6 4];
M = [3 6 5 5 4; 
     4 4 5 6 6];
% --------------------------------
[r, k] = size(M);
for i = 1:k,
    p.x = M(1, i);
    p.y = M(2, i);
    L_puntos(i) = p;
end

cuerpo = [L_puntos L_puntos(1)];
RmasP = obstaculo_crecido(brazo, L_puntos);
cuerpo_crecido = [RmasP RmasP(1)];

[r, nc] = size(cuerpo);
for i=1:nc
    xc(i) = cuerpo(i).x;
    yc(i) = cuerpo(i).y;
end

[r, ncc] = size(cuerpo_crecido);
for i=1:ncc
    xcc(i) = cuerpo_crecido(i).x;
    ycc(i) = cuerpo_crecido(i).y;
end

plot(xc, yc, 'b'); hold on
plot(xb, yb, 'k'); hold on
plot(brazo.p2.x, brazo.p2.y, 'ok');
grid; pause; hold on;
plot(xcc, ycc, 'r'); hold on

