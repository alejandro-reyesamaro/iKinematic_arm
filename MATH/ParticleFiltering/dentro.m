function r = dentro(P, p)
% Esta funcion nos dir'a si un punto est'a dentro de un poligono (convexo)
    ptos = max(size(P.ptos));    
    cayo_dentro = 0;
    esta_entre = 0;
    for i = 1 : ptos
        s.p1.x = P.ptos(i).x;
        s.p1.y = P.ptos(i).y;
        if i == ptos
            s.p2.x = P.ptos(1).x;
            s.p2.y = P.ptos(1).y;
        else
            s.p2.x = P.ptos(i+1).x;
            s.p2.y = P.ptos(i+1).y;
        end
        edos = entredos(s, p);
        cayo_dentro = cayo_dentro + abs(edos);
        esta_entre  = esta_entre + edos;
    end
    r = cayo_dentro > 0 && esta_entre == 0;
end

function r = entredos(S, p)
% Devuelve:
% -1 si la recta est'a por debajo del punto
%  1 si la recta est'a por encima del punto
%  0 si el punto pertenece a la recta
    r = 0;
    if (S.p1.x <= p.x && S.p2.x > p.x) || (S.p2.x <= p.x && S.p1.x > p.x)
        yr = evalua_recta(S, p.x);
        rest = yr - p.y;
        if abs(rest) >= eps
            r = rest/abs(rest);
        end
    end
end