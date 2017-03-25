function RmasP = obstaculo_crecido(a, L_puntos)
% Esta funci�n calcula espacio prohibido de configuraciones de un brazo
% mecanico representado por el segmento "a". El resultado es una lista de
% puntos que representan el obst�culo crecido: "RmasP"

i = 1; j = 1;
n = 2;
[r,m] = size(L_puntos);
V = [a.p1 a.p2 a.p1];
W = [L_puntos L_puntos(1)];

RmasP = [];
p_suma = mas(V(i), W(j));
RmasP = [RmasP p_suma];

if angulo(V(i), V(i+1)) < angulo(W(j), W(j+1))
    i = i + 1;
else if angulo(V(i), V(i+1)) > angulo(W(j), W(j+1))
    j = j + 1;
else
    i = i + 1; j = j + 1;
end

while i < n + 1 | j < m + 1,
    p_suma = mas(V(i), W(j));
    RmasP = [RmasP p_suma];
    
    if i > n | j > m 
        break;
    end %IF
    if angulo(V(i), V(i+1)) < angulo(W(j), W(j+1))
        i = i + 1;
    elseif angulo(V(i), V(i+1)) > angulo(W(j), W(j+1))
        j = j + 1;
    else
        i = i + 1; j = j + 1;
    end %IF
    
end %WHILE
end %FUNCTION