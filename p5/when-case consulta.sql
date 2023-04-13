use mibasesamuelalegre;
SELECT
    COALESCE(SUM(CASE WHEN Departamento = 'Chuquisaca' THEN notafinal END), 0) chuquisaca,
    COALESCE(SUM(CASE WHEN Departamento = 'La Paz' THEN notafinal  END), 0) lapaz,
    COALESCE(SUM(CASE WHEN Departamento = 'Cochabamba' THEN notafinal END), 0) cochabamba,
    COALESCE(SUM(CASE WHEN Departamento = 'Oruro' THEN notafinal  END), 0) oruro,
    COALESCE(SUM(CASE WHEN Departamento = 'Potosi' THEN notafinal  END), 0) potosi,
    COALESCE(SUM(CASE WHEN Departamento = 'Tarija' THEN notafinal  END), 0) tarija,
    COALESCE(SUM(CASE WHEN Departamento = 'Santa Cruz' THEN notafinal END), 0) santacruz,
    COALESCE(SUM(CASE WHEN Departamento = 'Beni' THEN notafinal  END), 0) beni,
    COALESCE(SUM(CASE WHEN Departamento = 'Pando' THEN notafinal  END), 0) pando,
    COALESCE(SUM(CASE WHEN Departamento = 'Otro' THEN notafinal  END), 0) otro
FROM(
    SELECT
        (CASE 
            WHEN Departamento = '01' THEN 'Chuquisaca'
            WHEN Departamento = '02' THEN 'La Paz'
            WHEN Departamento = '03' THEN 'Cochabamba'
            WHEN Departamento = '04' THEN 'Oruro'
            WHEN Departamento = '05' THEN 'Potosi'
            WHEN Departamento = '06' THEN 'Tarija'
            WHEN Departamento = '07' THEN 'Santa Cruz'
            WHEN Departamento = '08' THEN 'Beni'
            WHEN Departamento = '09' THEN 'Pando'
            ELSE 'Otro'
        END) AS Departamento,
        AVG(notafinal) AS notafinal
    FROM(
        SELECT i.notafinal, p.Departamento
        FROM persona p
        INNER JOIN inscripcion i ON i.CIestudiante = p.CI
    ) AS notas
    GROUP BY Departamento
) AS agregado