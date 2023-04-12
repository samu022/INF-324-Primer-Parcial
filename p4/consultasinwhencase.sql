use mibasesamuelalegre;

SELECT
									COALESCE(SUM(IF(Departamento = 'Chuquisaca', notafinal, NULL)), 0) chuquisaca,
									    COALESCE(SUM(IF(Departamento = 'La Paz', notafinal, NULL)), 0) lapaz,
									    COALESCE(SUM(IF(Departamento = 'Cochabamba', notafinal, NULL)), 0) cochabamba,
									    COALESCE(SUM(IF(Departamento = 'Oruro', notafinal, NULL)), 0) oruro,
									    COALESCE(SUM(IF(Departamento = 'Potosi', notafinal, NULL)), 0) potosi,
									    COALESCE(SUM(IF(Departamento = 'Tarija', notafinal, NULL)), 0) tarija,
									    COALESCE(SUM(IF(Departamento = 'Santa Cruz', notafinal, NULL)), 0) santacruz,
									    COALESCE(SUM(IF(Departamento = 'Beni', notafinal, NULL)), 0) beni,
									    COALESCE(SUM(IF(Departamento = 'Pando', notafinal, NULL)), 0) pando,
									    COALESCE(SUM(IF(Departamento = 'Otro', notafinal, NULL)), 0) otro
									FROM(
										SELECT
											IF(Departamento = '01', 'Chuquisaca',
											IF(Departamento = '02', 'La Paz',
											IF(Departamento = '03', 'Cochabamba',
											IF(Departamento = '04', 'Oruro',
											IF(Departamento = '05', 'Potosi',
											IF(Departamento = '06', 'Tarija',
											IF(Departamento = '07', 'Santa Cruz',
											IF(Departamento = '08', 'Beni',
											IF(Departamento = '09', 'Pando', 'Otro'))))))))) AS Departamento,
											AVG(notafinal) AS notafinal
										FROM(
											SELECT i.notafinal, p.Departamento
											FROM persona p
											INNER JOIN inscripcion i ON i.CIestudiante = p.CI
										) AS notas
										GROUP BY IF(Departamento = '01', 'Chuquisaca',
												IF(Departamento = '02', 'La Paz',
												IF(Departamento = '03', 'Cochabamba',
												IF(Departamento = '04', 'Oruro',
												IF(Departamento = '05', 'Potosi',
												IF(Departamento = '06', 'Tarija',
												IF(Departamento = '07', 'Santa Cruz',
												IF(Departamento = '08', 'Beni',
												IF(Departamento = '09', 'Pando', 'Otro')))))))))
									) AS agregado
									LIMIT 10