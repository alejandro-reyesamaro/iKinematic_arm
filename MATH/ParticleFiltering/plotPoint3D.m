% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: plotUnitVector
% description:  Plot a list of points 3D. size(list) = (x,3) x= number of
% poits
%               input: list
%               output: plot
function h=plotPoint3D(list)
for i=1:size(list,1)
    h=plot3([0,list(i,1)],[0,list(i,2)],[0,list(i,3)]);
    hold on;
end;
hold off;
grid on;