select case
where A+B<=C or A+C<=B or B+C<=A then 'Not A Triangle'
where A=B and A=C and B=C then 'Equilateral'
where A=B or A=C or B=C then 'Isosceles'
else 'Scalene'
end
from TRIANGLES ;
select round(sum(LAT_N),2) , round(sum(LONG_W),2)
