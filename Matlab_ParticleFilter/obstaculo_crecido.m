function RmasP = obstaculo_crecido(a, L_puntos)
% Esta funci�n calcula espacio prohibido de configuraciones de un brazo
% mecanico representado por el segmento "a". El resultado es una lista de
% puntos que representan el obst�culo crecido: "RmasP"

i = 1; j = 1;
n = 2;
[r,m] = size(L_puntos);
V = [a.p1 a.p2 a.p1 a.p2 a.p1 a.p2];
W = [L_puntos L_puntos(1)];

RmasP = [];
p_suma = mas(V(i), W(j));
RmasP = [RmasP p_suma];

angV = angulo(V(i), V(i+1), 0);
angW = angulo(W(j), W(j+1), 0);
if angV < angW
    i = i + 1;
elseif angV > angW
    j = j + 1;
else
    i = i + 1; j = j + 1;
end

while i < n + 2 && j < m + 2,
    p_suma = mas(V(i), W(j));
    RmasP = [RmasP p_suma];
    
    if i > n || j > m 
        break;
    end %IF
    
    angV_ = angulo(V(i), V(i+1), angV);
    angW_ = angulo(W(j), W(j+1), angW);
    
    if angV_ < angW_
        i = i + 1;
    elseif angV_ > angW_
        j = j + 1;
    else
        i = i + 1; j = j + 1;
    end %IF
    
    angV = angV_;
    angW = angW_;
    
end %WHILE

end %FUNCTION

